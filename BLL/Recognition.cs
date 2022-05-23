using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Topology;
using DotSpatial.Topology.Algorithm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDSystem
{
    public class Line
    {
        private int numPoints;
        public int NumPoints
        {
            get { return Points.Count; }
            set{ numPoints = value; }
        }   //点的总数目
        public List<Coordinate> Points = new List<Coordinate>(); //所有部分的点
        public double Contour { get; set; }

        public Line(int NumPoints, List<Coordinate> Points)   //构造函数
        {
            this.NumPoints = NumPoints;
            this.Points = Points;
        }

        public Line(int NumPoints, List<Coordinate> Points, double contour)
        {
            this.NumPoints = NumPoints;
            this.Points = Points;
            this.Contour = contour;
        }

        public void Add(Coordinate poi)
        {
            Points.Add(poi);
        }
    }

    class Recognition
    {
        static double interval = 50;
        /// <summary>
        /// 直线段河流提取
        /// </summary>
        /// <param name="coords">点集</param>
        /// <param name="alw">阈值</param>
        /// <returns>识别出的直线段</returns>
        public static List<Line> Line(List<DotSpatial.Topology.Coordinate> coords,int alw)
        {
            List<Line> polylines = new List<Line>();   //储存所有直线
            List<Line> lines = new List<Line>();   //储存所有满足条件(超过阈值)的直线

            for (int i = 0; i < coords.Count - 1; i++)
            {
                double theta = 0;   //该直线的θ值
                int NumPoints = 0;   //该直线的点数
                double r1 = 0;
                r1 = coords[i].X * Math.Cos(theta) + coords[i].Y * Math.Sin(theta);
                theta = Math.Atan((coords[i].X - coords[i + 1].X) / (coords[i + 1].Y - coords[i].Y));   //求出θ角      
                List<DotSpatial.Topology.Coordinate> line = new List<DotSpatial.Topology.Coordinate>();
                for (int j = i + 1; j < coords.Count; j++)
                {
                    double r2 = 0;
                    r2 = coords[j].X * Math.Cos(theta) + coords[j].Y * Math.Sin(theta);
                    if (Math.Abs(r1 - r2) <= 0)   //r1与r2近似相等,可调整近似程度
                    {

                        if (NumPoints == 0)   //第一次满足
                        {
                            line.Add(new DotSpatial.Topology.Coordinate(coords[i]));
                            line.Add(new DotSpatial.Topology.Coordinate(coords[j]));

                            NumPoints = 2;
                        }
                        else   //第二次满足
                        {
                            line.Add(new DotSpatial.Topology.Coordinate(coords[j]));

                            NumPoints++;
                        }
                        i++;
                    }
                    else
                        break;
                }
                polylines.Add(new Line(NumPoints, line));
            }

            for (int i = 0; i < polylines.Count; i++)
            {
                if (polylines[i].NumPoints >= alw )   //阈值设定,直线长度阈值设定
                    lines.Add(polylines[i]);
            }

            return lines;
        }

        /// <summary>
        /// 火山识别算法
        /// </summary>
        /// <param name="ContourlineLayer">含有待识别等高线的图层</param>
        /// <param name="lineF0"></param>
        /// <param name="Th1">面积阈值</param>
        /// <param name="Th2">外包矩形长宽比阈值</param>
        /// <param name="Th3">圆心阈值</param>
        /// <param name="Th4">半径阈值</param>
        /// <param name="Th5">霍夫变换阈值</param>
        /// <param name="Th6">真圆最少点阈值</param>
        /// <returns></returns>
        public static List<List<Circle>> Volcano(MapLineLayer ContourlineLayer, FeatureSet lineF0, double Th1, double Th2, double Th3, double Th4, int Th5, int Th6)
        {
            IFeatureSet p = ContourlineLayer.FeatureSet;
            List<Circle> circles = new List<Circle>();
            List<List<Circle>> Group = new List<List<Circle>>();

            for (int j = 0; j < p.NumRows(); j++)   //NumRows可查看有几条线
            {
                IFeature pi = p.GetFeature(j);   //pi为一shapefile主文件
                double contour = Convert.ToDouble(pi.DataRow["CONTOUR"]);
                var box = pi.Envelope;

                List<Coordinate> Coords = pi.Coordinates.ToList();
                Coords.ForEach(delegate (Coordinate PointCoords)   //将主文件中点读出存入Coords中
                {
                    DotSpatial.Topology.Point Point = new DotSpatial.Topology.Point(PointCoords);
                });
                if (Alw(Coords, box, Th1, Th2,Th3))
                {
                    Circle circle;
                    circle = HoughCircle(Coords, Th3, Th4, Th5, Th6);
                    if (circle != null)
                    {
                        circle.Contour = contour;
                        circle.Id = j;
                        circles.Add(circle);
                    }
                }
            }
            if (circles.Count == 0)
            {
                return null;
            }
            Group = GroupByHeight(circles, p);
            if (Group.Count > 0)
            {
                Group = Crater(p, Group);
            }
            for (int i = 0; i < Group.Count; i++)
            {
                double max=Group[i][0].Contour,min= Group[i][0].Contour;
                int max_id = 0;
                for (int j = 1; j < Group[i].Count; j++)
                {
                    if (Group[i][j].Contour > max)
                    {
                        max = Group[i][j].Contour;
                        max_id = j;
                    }
                    if (Group[i][j].Contour < min)
                        min = Group[i][j].Contour;
                }
                Group[i][0].Height = max - min;
                Group[i][0].Slope = Math.Atan((max - min) / (max_id * interval));
            }

            return Group;
        }

        /// <summary>
        /// 霍夫变换提取圆
        /// </summary>
        /// <param name="coords"></param>
        /// <param name="Th3">圆心阈值</param>
        /// <param name="Th4">半径阈值</param>
        /// <param name="Th5">霍夫变换阈值</param>
        /// <param name="Th6">真圆最少点阈值</param>
        /// <returns></returns>
        public static Circle HoughCircle(List<Coordinate> coords,double Th3,double Th4, int Th5,int Th6)
        {
            //闭合初筛
            if (coords[0].X != coords[coords.Count - 1].X || coords[0].Y != coords[coords.Count - 1].Y)
                return null;
            List<Hough> Hough_list = new List<Hough>();
           
            double x0 = 0, y0 = 0, radius = 0;
            int[] index = new int[coords.Count];
            for (int i = 0; i < coords.Count; i++)
                index[i] = i;
            int site = coords.Count;//设置下限

            while(Hough_list.Count <= 10*(Math.Pow(coords.Count,3)/ Math.Pow(0.8*coords.Count, 3)))
            {
                Random r = new Random();
                int[] result = new int[3];
                int id;
                
                for (int j = 0; j < 3; j++)
                {
                    id = r.Next(0, site);
                    //在随机位置取出一个数，保存到结果数组
                    result[j] = index[id];
                    //最后一个数复制到当前位置
                    index[id] = index[site - 1];
                    //位置的下限减少一
                    site--;
                }
                //重置，放回抽样
                site = coords.Count;

                double a = coords[result[0]].X - coords[result[1]].X;
                double b = coords[result[0]].Y - coords[result[1]].Y;
                double c = coords[result[0]].X - coords[result[2]].X;
                double d = coords[result[0]].Y - coords[result[2]].Y;
                double e = ((coords[result[0]].X * coords[result[0]].X) - (coords[result[1]].X * coords[result[1]].X) - (coords[result[1]].Y * coords[result[1]].Y) + (coords[result[0]].Y * coords[result[0]].Y)) / 2.0;
                double f = ((coords[result[0]].X * coords[result[0]].X) - (coords[result[2]].X * coords[result[2]].X) - (coords[result[2]].Y * coords[result[2]].Y) + (coords[result[0]].Y * coords[result[0]].Y)) / 2.0;
                x0 = -(d * e - b * f) / (b * c - a * d);
                y0 = -(a * f - c * e) / (b * c - a * d);
                radius = Math.Sqrt((coords[result[0]].X - x0) * (coords[result[0]].X - x0) + (coords[result[0]].Y - y0) * (coords[result[0]].Y - y0));

                if (Hough_list.Count > 0)
                {
                    int j = 0;
                    for (; j < Hough_list.Count; j++)
                    {
                        if (Math.Abs(x0 - Hough_list[j].a) < Th3 &&
                            Math.Abs(y0 - Hough_list[j].b) < Th3 &&
                            Math.Abs(radius - Hough_list[j].r) < Th4)
                        {
                            Hough_list[j].count++;
                            if (!Hough_list[j].p.Contains(coords[result[0]]))
                                Hough_list[j].p.Add(coords[result[0]]);
                            else if(!Hough_list[j].p.Contains(coords[result[1]]))
                                Hough_list[j].p.Add(coords[result[1]]);
                            else if (!Hough_list[j].p.Contains(coords[result[2]]))
                                Hough_list[j].p.Add(coords[result[2]]);
                            break;
                        }
                       
                    }
                    //若无此参数，新增参数列
                    if (j >= Hough_list.Count)
                    {
                        List<Coordinate> p = new List<Coordinate>();
                        p.Add(coords[result[0]]);
                        p.Add(coords[result[1]]);
                        p.Add(coords[result[2]]);
                        Hough hough = new Hough(x0, y0, radius, p);
                        Hough_list.Add(hough);
                    }
                    else
                    {
                        //大于霍夫变换阈值Th5且大于真圆最少点阈值Th6
                        if (Hough_list[j].count > Th5)
                        {
                            if (Hough_list[j].p.Count > Th6)
                            {
                                return new Circle(Hough_list[j].a, Hough_list[j].b, Hough_list[j].r, coords);
                            }
                            else
                            {
                                Hough_list[j].count = 0;
                            }
                        }
                    }
                    
                }
                else
                {
                    List<Coordinate> p = new List<Coordinate>();
                    p.Add(coords[result[0]]);
                    p.Add(coords[result[1]]);
                    p.Add(coords[result[2]]);
                    Hough hough = new Hough(x0, y0, radius, p);
                    Hough_list.Add(hough);
                }
            }
            return null;
        }      

        public static List<List<Circle>> Crater(IFeatureSet p, List<List<Circle>> Group)
        {
            List<List<Circle>> order_crater = new List<List<Circle>>();
            Circle temp = new Circle();
            for (int i = 0; i < Group.Count; i++)
            {
                List<Circle> Ck = new List<Circle>();
                for (int j = 0; j < Group[i].Count; j++)
                {
                    //Group[i][j].Area = Math.Abs(CgAlgorithms.SignedArea(Group[i][j].Points));
                    Ck.Add(Group[i][j]);
                }

                for (int a = 0; a < Ck.Count - 1; a++)
                {
                    for (int b = 0; b < Ck.Count - a - 1; b++)
                    {

                        if (Ck[b].Area < Ck[b + 1].Area)
                        {
                            temp = Ck[b].Clone();
                            Ck[b] = Ck[b + 1].Clone();
                            Ck[b + 1] = temp;
                        }
                    }
                }

                order_crater.Add(Ck);

            }

            
            //隶属度判断
            for (int i = 0; i < order_crater.Count; i++)
            {
                order_crater[i][0].Edge = true;
                double max_contour = order_crater[i][0].Contour;
                bool Ascending = false;
                bool crater = false;
                for (int a = 1; a < order_crater[i].Count; a++)
                {
                    //先增后减判断
                    if (Ascending && max_contour > order_crater[i][a].Contour)
                    {
                        crater = true;
                        Ascending = false;
                    }
                    if (crater && max_contour < order_crater[i][a].Contour)
                    {
                        crater = false;
                    }
                    //单调递增判断
                    if (max_contour <= order_crater[i][a].Contour)
                    {
                        max_contour = order_crater[i][a].Contour;
                        Ascending = true;
                    }
                    else
                    {
                        Ascending = false;
                    }

                }

                if (crater)
                    for (int b = 0; b < order_crater[i].Count; b++)
                    {
                        if (order_crater[i][b].Grade == 0)
                            order_crater[i][b].Grade = 0.9;
                    }
                else if (Ascending)
                    for (int b = 0; b < order_crater[i].Count; b++)
                    {
                        if (order_crater[i][b].Grade == 0)
                            order_crater[i][b].Grade = 0.8;
                    }

            }

            return order_crater;
        }

        

        public static FeatureSet Property(FeatureSet lineF0)
        {
            DataColumn column1 = new DataColumn("LineID");
            DataColumn column2 = new DataColumn("Area");
            DataColumn column3 = new DataColumn("CenterX");
            DataColumn column4 = new DataColumn("CenterY");
            DataColumn column5 = new DataColumn("Radius");
            DataColumn column6 = new DataColumn("CONTOUR");
            DataColumn column7 = new DataColumn("Grade");
            DataColumn column8 = new DataColumn("Edge");

            if (!lineF0.DataTable.Columns.Contains("LineID"))
            {
                lineF0.DataTable.Columns.Add(column1);
            }
            if (!lineF0.DataTable.Columns.Contains("Area"))
            {
                lineF0.DataTable.Columns.Add(column2);
            }
            if (!lineF0.DataTable.Columns.Contains("CenterX"))
            {
                lineF0.DataTable.Columns.Add(column3);
            }
            if (!lineF0.DataTable.Columns.Contains("CenterY"))
            {
                lineF0.DataTable.Columns.Add(column4);
            }
            if (!lineF0.DataTable.Columns.Contains("Radius"))
            {
                lineF0.DataTable.Columns.Add(column5);
            }
            if (!lineF0.DataTable.Columns.Contains("CONTOUR"))
            {
                lineF0.DataTable.Columns.Add(column6);
            }
            if (!lineF0.DataTable.Columns.Contains("Grade"))
            {
                lineF0.DataTable.Columns.Add(column7);
            }
            if (!lineF0.DataTable.Columns.Contains("Edge"))
            {
                lineF0.DataTable.Columns.Add(column8);
            }

            return lineF0;
        }

        /// <summary>
        /// 等高线分组
        /// </summary>
        /// <param name="circles">圆形等高线</param>
        /// <param name="p">等高线要素类</param>
        /// <returns>分组圆形等高线</returns>
        private static List<List<Circle>> GroupByHeight(List<Circle> circles, IFeatureSet p)
        {
            List<double> S = new List<double>();
            List<List<Circle>> C = new List<List<Circle>>();
            for (int i = 0; i < circles.Count; i++)
            {
                double s = Math.Abs(CgAlgorithms.SignedArea(circles[i].Points));  
                S.Add(s);
                circles[i].Area = s;
            }
            //标记等高线是否已分组
            List<int> groupflags = new List<int>();
            int k = 0;//分组标记，移除了的不再移除
            while(S.Count>0)
            {
                List<Circle> ck = new List<Circle>();
                double areamax = S.Max();
                int i;
                //i = S.FindIndex(s => s== areamax);//找面积最大等高线
                i = circles.FindIndex(s => s.Area == areamax);//找面积最大等高线
                Feature pi = (Feature)p.GetFeature(circles[i].Id);
                ck.Add(circles[i]);
                groupflags.Add(i);
                for (int j = 0; j < circles.Count; j++)
                {
                    //假如满足条件：1.没有进行分组；2.包含于最大面积等高线内
                    if (!groupflags.Contains(j) && pi.Envelope.Contains(new Coordinate(circles[j].CenterX, circles[j].CenterY)))
                    {
                        ck.Add(circles[j]);
                        groupflags.Add(j);
                        
                    }
                }
                //S.Remove(areamax);
                for(;k< groupflags.Count;k++)
                    S.Remove(circles[groupflags[k]].Area);//移除分组了的面积
                if (ck.Count > 1)
                    C.Add(ck);
                
            }

            return C;
            
        }

        private static bool Alw(List<Coordinate> coords, IEnvelope box,double Th1,double Th2,double Th3)
        {
            double s = Math.Abs(CgAlgorithms.SignedArea(coords));
            if (s > Th1)
            {
                double a = box.Height, b = box.Width;
                double Ths ;
                if (s > (Math.PI * a * b / 4))
                    Ths = s / (Math.PI * a * b / 4);
                else
                    Ths = (Math.PI * a * b / 4) / s;
                if (Ths<Th2)
                {
                    if (a > b)
                    {
                        if ((a / b) < Th2)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        if ((b / a) < Th2)
                            return true;
                        else
                            return false;
                    }
                }
                else
                    return false;
                
            }
            else
                return false;
        }

        
    }
}
