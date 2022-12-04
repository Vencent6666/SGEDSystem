using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Symbology;
using DotSpatial.Topology;
using DotSpatial.Topology.Algorithm;
using DotSpatial.Plugins.Measure;

namespace SGEDSystem
{
    public partial class MainForm : Form
    {
        List<shpclass.Polygon> pologons = new List<shpclass.Polygon>();//面集合
        List<shpclass.Polyline> polylines = new List<shpclass.Polyline>();//线集合
        List<shpclass.Point> points = new List<shpclass.Point>();//点集合
        private string theme = string.Empty;
        List<string> Filepath_List = new List<string>();
        string shapeType;
        int ShapeType;//shp文件类型
        //int count;//计数
        double xmin, ymin, xmax, ymax;
        //double n1, n2;//x,y轴放大倍数
        string Filepath=string.Empty;
        string Zjlj_Path = "";
        string Sblj_Path = "";
        string Xjlj_Path = "";
        bool LoadStart = false;

        private double Th1 = 500;
        private double Th2 = 500;
        private double Th3 = 500;
        private double Th4 = 500;
        //private int Th5 = 0;
        private int Th6 = 0;

        #region Point ShapeFile class level variable

        //the new point feature set
        FeatureSet pointF = new FeatureSet(FeatureType.Point);

        //the id of point
        int pointID = 0;

        //to differentiate the right and left mouse click
        bool pointmouseClick = false;

        #endregion

        #region Polyline  ShapeFile class level variables

        MapLineLayer lineLayer = default(MapLineLayer);

        //the line feature set
        FeatureSet lineF = new FeatureSet(FeatureType.Line);

        int lineID = 0;

        //boolean variable for first time mouse click
        bool firstClick = false;

        //It controls the drawing the polyline after the polyline saved operation.
        bool linemouseClick = false;

        #endregion

        #region Polygon ShapeFile class level variables

        FeatureSet polygonF = new FeatureSet(FeatureType.Polygon);

        int polygonID = 0;

        bool polygonmouseClick = false;

        #endregion

        #region line0  ShapeFile class level variables

        //MapLineLayer lineLayer0 = default(MapLineLayer);

        //the line feature set
        FeatureSet lineF0 = new FeatureSet(FeatureType.Line);

        int lineID0 = 0;

        #endregion
      

        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "所有文件 (*.*)|*.*|Shapefiles (*.shp)|*.shp";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //获取指定文件的路径
                    Filepath = openFileDialog.FileName;
                    Filepath_List.Add(Filepath);
 
                    Map1.AddLayer(Filepath);
                }
            }
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear() method is used to clear the layers from the map control.
            Map1.Layers.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Confirm with users that  they are ready to close application or not with the help of message box.
            if (MessageBox.Show("是否要退出程序", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Close() method is used to close the application.
                this.Close();
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.ZoomOut();
        }

        private void zoomExtentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Confirm with users that  they are ready to close application or not with the help of message box.
            Map1.ZoomToMaxExtent();
        }

        private void Map1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (shapeType)
            {
                case "Point":
                    if (e.Button == MouseButtons.Left)
                    {
                        if ((pointmouseClick))
                        {
                            //This method is used to convert the screen cordinate to map coordinate
                            //e.location is the mouse click point on the map control
                            Coordinate coord = Map1.PixelToProj(e.Location);

                            //Create a new point
                            //Input parameter is clicked point coordinate
                            DotSpatial.Topology.Point point = new DotSpatial.Topology.Point(coord);

                            //Add the point into the Point Feature
                            //assigning the point feature to IFeature because via it only we can set the attributes.
                            IFeature currentFeature = pointF.AddFeature(point);

                            //increase the point id
                            pointID = pointID + 1;

                            //set the ID attribute
                            currentFeature.DataRow["ID"] = pointID;

                            //refresh the map
                            Map1.ResetBuffer();
                        }
                    }
                    else
                    {
                        //mouse right click
                        Map1.Cursor = Cursors.Default;
                        pointmouseClick = false;
                    }
                    break;

                case "line":
                    if (e.Button == MouseButtons.Left)
                    {
                        //left click - fill array of coordinates
                        //coordinate of clicked point
                        Coordinate coord = Map1.PixelToProj(e.Location);
                        if (linemouseClick)
                         {
                            if (firstClick)
                            {
                                //Create a new List called lineArray.                          
                                //This list will store the Coordinates
                                //We are going to store the mouse click coordinates into this array.
                                List<Coordinate> lineArray = new List<Coordinate>();

                                //Create an instance for LineString class.
                                //We need to pass collection of list coordinates
                                LineString lineGeometry = new LineString(lineArray);

                                //Add the linegeometry to line feature
                                IFeature lineFeature = lineF.AddFeature(lineGeometry);
                                //add first coordinate to the line feature
                                lineFeature.Coordinates.Add(coord);
                                //set the line feature attribute
                                lineID = lineID + 1;
                                lineFeature.DataRow["LineID"] = lineID;
                                firstClick = false;
                            }
                            else
                            {
                                //second or more clicks - add points to the existing feature
                                IFeature existingFeature = lineF.Features[lineF.Features.Count - 1];
                                existingFeature.Coordinates.Add(coord);

                                //refresh the map if line has 2 or more points
                                if (existingFeature.Coordinates.Count >= 2)
                                {
                                    lineF.InitializeVertices();   //初始化顶点
                                    Map1.ResetBuffer();
                                }
                            }
                        }
                    }
                    else
                    {
                        //right click - reset first mouse click
                        firstClick = true;
                        Map1.ResetBuffer();
                    }
                    break;

                case "Polygon":
                    if (e.Button == MouseButtons.Left)
                    {
                        //left click - fill array of coordinates
                        Coordinate coord = Map1.PixelToProj(e.Location);
                        if (polygonmouseClick)
                        {
                            if (firstClick)
                            {
                                //Create a new List called polygonArray.

                                //this list will store the Coordinates
                                //We are going to store the mouse click coordinates into this array.

                                List<Coordinate> polygonArray = new List<Coordinate>();

                                //Create an instance for LinearRing class.
                                //We pass the polygon List to the constructor of this class
                                LinearRing polygonGeometry = new LinearRing(polygonArray);

                                //Add the polygonGeometry instance to PolygonFeature
                                IFeature polygonFeature = polygonF.AddFeature(polygonGeometry);

                                // add first coordinate to the polygon feature
                                polygonFeature.Coordinates.Add(coord);

                                //set the polygon feature attribute
                                polygonID = polygonID + 1;
                                polygonFeature.DataRow["PolygonID"] = polygonID;
                                firstClick = false;
                            }
                            else
                            {
                                //second or more clicks - add points to the existing feature
                                IFeature existingFeature = (IFeature)polygonF.Features[polygonF.Features.Count - 1];
                                existingFeature.Coordinates.Add(coord);

                                //refresh the map if line has 2 or more points
                                if (existingFeature.Coordinates.Count >= 3)
                                {
                                    //refresh the map
                                    polygonF.InitializeVertices();
                                    Map1.ResetBuffer();
                                }

                            }
                        }
                    }
                    else
                    {
                        //right click - reset first mouse click
                        firstClick = true;
                    }
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright © NNU GIS设计开发第七组. 2019");
        }

        private void Map1_GeoMouseMove(object sender, GeoMouseArgs e)
        {
            string locStr = "X:" + e.GeographicLocation.X.ToString("F2") +

                ", Y:" + e.GeographicLocation.Y.ToString("F2");

            toolStripStatusLabelXY.Text = locStr;

            //statusBar1.Width = this.Width - statusBarBlocker2.Width - 100;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TriangleForm f4 = new TriangleForm();
            //f4.ShowDialog();
            //if (f4.GetStart())
            //{
            //    if (Map1.Layers[0] is MapLineLayer)
            //    {
            //        MapLineLayer ContourlineLayer = default(MapLineLayer);
            //        ContourlineLayer = (MapLineLayer)Map1.Layers[0];
            //        IFeatureSet p = ContourlineLayer.FeatureSet;   //可查看有几条线
            //        LineScheme scheme = new LineScheme();

            //        for (int j = 0; j < p.NumRows(); j++)   //NumRows可查看有几条线
            //        {
            //            IFeature pi = p.GetFeature(j);   //pi为一shapefile主文件
            //            var box = pi.Envelope;
            //            double xmin = box.X, xmax = box.X + box.Width;
            //            double ymax = box.Y, ymin = box.Y - box.Height;
            //            List<Coordinate> Coords = pi.Coordinates.ToList();
            //            //FeatureSet point=new FeatureSet();
            //            Coords.ForEach(delegate (Coordinate PointCoords)   //将主文件中点读出存入Coords中
            //            {
            //                DotSpatial.Topology.Point Point = new DotSpatial.Topology.Point(PointCoords);
            //                //IFeature currentFeature = point.AddFeature(Point);
            //                //currentFeature.DataRow["ID"] = j;
            //                //currentFeature.DataRow["SourceLayer"] = i;
            //            });

            //            if (Recognition.Triangle(Coords, xmin, xmax, ymin, ymax,f4.GetVertices(),f4.GetDegree()))
            //            {
            //                String s = Convert.ToString(pi.DataRow.ItemArray[0]);
            //                ContourlineLayer.DataSet.FillAttributes();
            //                LineCategory category = new LineCategory(Color.Red, 5);
            //                string filter = "[ID] =" + s;
            //                category.FilterExpression = filter;
            //                category.LegendText = filter;
            //                scheme.AddCategory(category);

            //            }
            //        }

            //        ContourlineLayer.Symbology = scheme;
            //    }
            //}
            
        }

        private void craterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineID0 = 0;
            lineF0 = new FeatureSet(FeatureType.Line);
            CraterForm f2 = new CraterForm(Filepath_List);
            f2.txboutput.Text = Sblj_Path;
            f2.ShowDialog();
            if (f2.GetStart())
            {
                int i = GetLayerNumber(f2);
                ProgressBar1.Value = 10;
                if (Map1.Layers[i] is MapLineLayer)
                {
                    MapLineLayer ContourlineLayer = default(MapLineLayer);
                    ContourlineLayer = (MapLineLayer)Map1.Layers[i];
                    //List<Circle> crater = new List<Circle>();
                    List<List<Circle>> crater = new List<List<Circle>>();
                    lineF0.Projection = Map1.Projection;
                    crater = Recognition.Volcano(ContourlineLayer, lineF0, Th1, Th2, Th3, Th4, f2.GetAlw(), Th6);
                    ProgressBar1.Value = 80;

                    if (crater!=null && crater.Count > 0)
                    {
                        MessageBox.Show(string.Format("已提取{0}个火山", crater.Count));
                        List <Circle> craters= new List<Circle>();
                        for (int j = 0; j < crater.Count; j++)
                            for (int k = 0; k < crater[j].Count; k++)
                            {
                                craters.Add(crater[j][k]);
                            }
                        //MessageBox.Show("已提取{0}火山口",crater.Count);
                        CreateCrater(Recognition.Property(lineF0), craters, f2.Getoutfilepath(), f2.Getoutfilename());
                        if (f2.GetShow())
                        {
                            ProgressBar1.Value = 100;
                            Map1.AddLayer(f2.Getoutfilepath() + '\\' + f2.Getoutfilename() + ".shp");
                        }

                        ProgressBar1.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("该图层未找到对应地理实体");
                        ProgressBar1.Value = 0;
                    }
                }
            }
        }

        

        private int GetLayerNumber(CraterForm f2)
        {
            int i = 0;
            string str;
            string[] strArr = new string[2];
            str = f2.GetSelected();
            strArr = str.Split('.');
            for (; i < Map1.Layers.Count; i++)
            {
                if (Map1.Layers[i].LegendText == strArr[0])
                    break;
            }

            return i;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineID0 = 0;
            lineF0 = new FeatureSet(FeatureType.Line);
            LineForm f3 = new LineForm(Filepath_List);
            f3.txboutput.Text = Sblj_Path;
            f3.ShowDialog();
            if (f3.GetStart())
            {
                //确定图层
                int i = 0;
                for (; i < Map1.Layers.Count; i++)
                {
                    string str;
                    string[] strArr = new string[2];
                    str = f3.GetSelected();
                    strArr = str.Split('.');
                    if (Map1.Layers[i].LegendText == strArr[0])
                        break;
                }
                ProgressBar1.Value = 10;
                if (Map1.Layers[i] is MapLineLayer)
                {
                    MapLineLayer ContourlineLayer = default(MapLineLayer);
                    ContourlineLayer = (MapLineLayer)Map1.Layers[0];
                    IFeatureSet p = ContourlineLayer.FeatureSet;   //可查看有几条线
                                                                   //LineScheme scheme = new LineScheme();
                    List<Line> lines = new List<Line>();

                    //set projection
                    lineF0.Projection = Map1.Projection;

                    //initialize the featureSet attribute table
                    DataColumn column1 = new DataColumn("LineID");
                    DataColumn column2 = new DataColumn("Length");
                    DataColumn column3 = new DataColumn("StartX");
                    DataColumn column4 = new DataColumn("StartY");
                    DataColumn column5 = new DataColumn("EndX");
                    DataColumn column6 = new DataColumn("EndY");

                    if (!lineF0.DataTable.Columns.Contains("LineID"))
                    {
                        lineF0.DataTable.Columns.Add(column1);
                    }
                    if (!lineF0.DataTable.Columns.Contains("Length"))
                    {
                        lineF0.DataTable.Columns.Add(column2);
                    }
                    if (!lineF0.DataTable.Columns.Contains("StartX"))
                    {
                        lineF0.DataTable.Columns.Add(column3);
                    }
                    if (!lineF0.DataTable.Columns.Contains("StartY"))
                    {
                        lineF0.DataTable.Columns.Add(column4);
                    }
                    if (!lineF0.DataTable.Columns.Contains("EndX"))
                    {
                        lineF0.DataTable.Columns.Add(column5);
                    }
                    if (!lineF0.DataTable.Columns.Contains("EndY"))
                    {
                        lineF0.DataTable.Columns.Add(column6);
                    }
                    ProgressBar1.Value = 30;
                    //add the featureSet as map layer
                    //lineLayer0 = (MapLineLayer)Map1.Layers.Add(lineF0);

                    ////Set the symbolizer to the line feature.
                    //LineSymbolizer symbol = new LineSymbolizer(Color.Red, 2);
                    //lineLayer0.Symbolizer = symbol;
                    //lineLayer0.LegendText = "river";

                    int line = 0;

                    for (int j = 0; j < p.NumRows(); j++)   //NumRows可查看有几条线
                    {
                        IFeature pi = p.GetFeature(j);   //pi为一shapefile主文件
                        List<Coordinate> Coords = pi.Coordinates.ToList();
                        Coords.ForEach(delegate (Coordinate PointCoords)   //将主文件中点读出存入Coords中
                        {
                            DotSpatial.Topology.Point Point = new DotSpatial.Topology.Point(PointCoords);
                            //IFeature currentFeature = point.AddFeature(Point);
                            //currentFeature.DataRow["ID"] = j;
                            //currentFeature.DataRow["SourceLayer"] = i;
                        });

                        lines = Recognition.Line(Coords, Convert.ToInt16(f3.GetAlw()));
                            if ( CreateRiver( lines,f3.Getoutfilepath(),f3.Getoutfilename() ) )
                                line++;
                    }
                    ProgressBar1.Value = 80;
                    if (line > 1)
                    {
                        MessageBox.Show("已提取直线段河流");
                        if (f3.GetShow())
                        {
                            ProgressBar1.Value = 100;
                            Map1.AddLayer(f3.Getoutfilepath() + '\\' + f3.Getoutfilename() + ".shp");
                        }
                        ProgressBar1.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("该图层未找到对应地理实体");
                        ProgressBar1.Value = 0;
                    }
                        
                }
            }
            

        }

        private bool CreateRiver(List<Line> lines, string filepath,string filename)
        {
            if (lines.Count > 0)   //创建线要素
            {

                for (int i = 0; i < lines.Count; i++)   //每条线
                {
                    if (lines[i].NumPoints > 1)
                    {
                        if (lines[i].Points[0].X == lines[i].Points[1].X && lines[i].Points[0].Y == lines[i].Points[1].Y)
                            break;
                        for (int k = 0; k < lines[i].NumPoints; k++)   //每条线的点
                        {
                            if (k == 0)
                            {
                                //Create a new List called lineArray.                          
                                //This list will store the Coordinates
                                List<Coordinate> lineArray = new List<Coordinate>();

                                //Create an instance for LineString class.
                                //We need to pass collection of list coordinates
                                LineString lineGeometry = new LineString(lineArray);

                                //Add the linegeometry to line feature
                                IFeature lineFeature = lineF0.AddFeature(lineGeometry);
                                //add first coordinate to the line feature
                                lineFeature.Coordinates.Add(lines[i].Points[k]);

                                //set the line feature attribute
                                lineID0 = lineID0 + 1;
                                lineFeature.DataRow["LineID"] = lineID0;
                                lineFeature.DataRow["Length"] = Math.Sqrt( Math.Pow(lines[i].Points[0].X - lines[i].Points[lines[i].Points.Count-1].X,2)+ Math.Pow(lines[i].Points[0].Y - lines[i].Points[lines[i].Points.Count - 1].Y,2));
                                lineFeature.DataRow["StartX"] = lineFeature.Coordinates[0].X;
                                lineFeature.DataRow["StartY"] = lineFeature.Coordinates[0].Y;
                                lineFeature.DataRow["EndX"] = lineFeature.Coordinates[lineFeature.Coordinates.Count - 1].X;
                                lineFeature.DataRow["EndY"] = lineFeature.Coordinates[lineFeature.Coordinates.Count - 1].Y;
                            }
                            else
                            {
                                IFeature existingFeature = lineF0.Features[lineF0.Features.Count - 1];
                                existingFeature.Coordinates.Add(lines[i].Points[k]);
                            }
                        }
                    }
                        
                }

                lineF0.SaveAs(filepath+ '\\'+filename+".shp", true); 
                return true;
            }
            else
                return false;
        }

        private bool CreateCrater(FeatureSet lineF0, List<Circle> circles, string filepath, string filename)
        {
            if (circles.Count > 0)   //创建线要素
            {

                for (int i = 0; i < circles.Count; i++)   //每条线
                {
                    if (circles[i].NumPoints > 1)
                    {
                        if (circles[i].Points[0].X == circles[i].Points[1].X && circles[i].Points[0].Y == circles[i].Points[1].Y)
                            break;
                        for (int k = 0; k < circles[i].NumPoints; k++)   //每条线的点
                        {
                            if (k == 0)
                            {
                                if (circles[i].Edge)
                                {
                                    DataColumn column = new DataColumn("Height");
                                    DataColumn column2 = new DataColumn("HWR");
                                    DataColumn column3 = new DataColumn("Slope");

                                    if (!lineF0.DataTable.Columns.Contains("Height"))
                                    {
                                        lineF0.DataTable.Columns.Add(column);
                                    }
                                    if (!lineF0.DataTable.Columns.Contains("HWR"))
                                    {
                                        lineF0.DataTable.Columns.Add(column2);
                                    }
                                    if (!lineF0.DataTable.Columns.Contains("Slope"))
                                    {
                                        lineF0.DataTable.Columns.Add(column3);
                                    }
                                }
                                List<Coordinate> lineArray = new List<Coordinate>();
                                LineString lineGeometry = new LineString(lineArray);
                                IFeature lineFeature = lineF0.AddFeature(lineGeometry);
                                lineFeature.Coordinates.Add(circles[i].Points[k]);

                                lineID0 = lineID0 + 1;

                                lineFeature.DataRow["LineID"] = circles[i].Id;
                                //lineFeature.DataRow["Area"] = Math.Abs(CgAlgorithms.SignedArea(circles[i].Points));
                                lineFeature.DataRow["Area"] = circles[i].Area;
                                lineFeature.DataRow["CenterX"] = circles[i].CenterX;
                                lineFeature.DataRow["CenterY"] = circles[i].CenterY;
                                lineFeature.DataRow["Radius"] = circles[i].Radius;
                                lineFeature.DataRow["CONTOUR"] = circles[i].Contour;
                                lineFeature.DataRow["Grade"] = circles[i].Grade;
                                lineFeature.DataRow["Edge"] = circles[i].Edge;
                                if (circles[i].Edge)
                                {
                                    lineFeature.DataRow["Height"] = circles[i].Height;
                                    lineFeature.DataRow["HWR"] = circles[i].Height/(2*circles[i].Radius);
                                    lineFeature.DataRow["Slope"] = circles[i].Slope;
                                    //if (circles[i].Slope > (33 * Math.PI / 180) && circles[i].Height < 300)
                                    //    lineFeature.DataRow["Class"] = "Cinder Cone";
                                    //else if(circles[i].Slope < (33 * Math.PI / 180) && circles[i].Height > 1000)
                                    //    lineFeature.DataRow["Class"] = "Composite";

                                }
                                    
                            }
                            else
                            {
                                IFeature existingFeature = lineF0.Features[lineF0.Features.Count - 1];
                                existingFeature.Coordinates.Add(circles[i].Points[k]);
                            }
                        }
                    }

                }

                lineF0.SaveAs(filepath + '\\' + filename + ".shp", true);
                return true;
            }
            else
                return false;
        }

        private void toolStripButtonDeselect_Click(object sender, EventArgs e)
        {
            Map1.ClearSelection();
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            Map1.Layers.Clear();
        }

        private void toolStripButtonNewShape_Click(object sender, EventArgs e)
        {
            ShapefileForm f1 = new ShapefileForm();
            f1.ShowDialog();
            if (f1.GetStart())
            {
                switch (f1.GetInformation())
                {
                    case "Point": CreatePoint(); break;
                    case "Polyline": CreatePolyline(); break;
                    case "Polygon": CreatePolygon(); break;
                    default:  break;
                }
            }
        }

        private bool CreatePolygon()
        {
            //initialize polyline feature set
            Map1.Cursor = Cursors.Cross;

            //set shape type
            shapeType = "Polygon";

            //set projection
            polygonF.Projection = Map1.Projection;

            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("PolygonID");

            if (!polygonF.DataTable.Columns.Contains("PolygonID"))
            {
                polygonF.DataTable.Columns.Add(column);
            }
            //add the featureSet as map layer
            MapPolygonLayer polygonLayer = (MapPolygonLayer)Map1.Layers.Add(polygonF);

            PolygonSymbolizer symbol = new PolygonSymbolizer(Color.Green);

            polygonLayer.Symbolizer = symbol;
            polygonLayer.LegendText = "Polygon";

            firstClick = true;

            polygonmouseClick = true;
            return true;
        }

        private bool CreatePolyline()
        {
            //Change the mouse cursor
            Map1.Cursor = Cursors.Cross;

            //set shape type
            shapeType = "line";

            //set projection
            lineF.Projection = Map1.Projection;

            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("LineID");

            if (!lineF.DataTable.Columns.Contains("LineID"))
            {
                lineF.DataTable.Columns.Add(column);
            }

            //add the featureSet as map layer
            lineLayer = (MapLineLayer)Map1.Layers.Add(lineF);

            //Set the symbolizer to the line feature.
            LineSymbolizer symbol = new LineSymbolizer(Color.Blue, 2);
            lineLayer.Symbolizer = symbol;
            lineLayer.LegendText = "line";

            firstClick = true;

            linemouseClick = true;
            return true;
        }

        private bool CreatePoint()
        {
            //Change the cursor style
            Map1.Cursor = Cursors.Cross;
            //set the shape type to the classlevel string variable
            //we are going to use this variable in select case statement
            shapeType = "Point";
            //set projection
            pointF.Projection = Map1.Projection;
            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("ID");
            pointF.DataTable.Columns.Add(column);
            //add the featureSet as map layer
            MapPointLayer pointLayer = (MapPointLayer)Map1.Layers.Add(pointF);
            //Create a new symbolizer
            PointSymbolizer symbol = new PointSymbolizer(Color.Red, DotSpatial.Symbology.PointShape.Ellipse, 3);
            //Set the symbolizer to the point layer
            pointLayer.Symbolizer = symbol;
            //Set the legentText as point
            pointLayer.LegendText = "point";
            //Set left mouse click as true
            pointmouseClick = true;
            return true;
        }

        private void toolStripButtonSaveShape_Click(object sender, EventArgs e)
        {
                switch (shapeType)
                {
                    case "Point":
                        pointF.SaveAs("Point.shp", true);
                        MessageBox.Show("The point shapefile has been saved.");
                        break;
                    case "Polyline":
                        lineF.SaveAs("Polyline.shp", true);
                        MessageBox.Show("The line shapefile has been saved.");
                        linemouseClick = false;
                        break;
                    case "Polygon":
                        polygonF.SaveAs("polygon.shp", true);
                        MessageBox.Show("The polygon shapefile first has been saved");
                        polygonmouseClick = false;
                        break;
                    default: break;
                }
                Map1.Cursor = Cursors.Arrow;   
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OverviewForm f1 = new OverviewForm();
            f1.Overview_Addfile(Filepath);
            f1.Show();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpDocument f1 = new HelpDocument();
            f1.Show();
        }

        private void AboutSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntroductionSystem f1 = new IntroductionSystem();
            f1.ShowDialog();
        }

        private void ConfigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (theme != string.Empty)
            {
                ConfigureForm f5 = new ConfigureForm(theme, Th1, Th2,Th3,Th4,Th6);
                f5.ShowDialog();
                if (f5.GetzjljStart())
                {
                    GetzjljPath(f5.GetzjljInformation());
                }
                if(f5.GetsbljStart())
                {
                    GetsbljPath(f5.GetsbljInformation());
                }
                if(f5.GetxjljStart())
                {
                    GetxjljPath(f5.GetxjljInformation());
                }
                if (f5.GetTheme() != string.Empty)
                {
                    skinEngine1.Active = true;
                    theme = f5.GetTheme();
                    skinEngine1.SkinFile = Application.StartupPath + theme;
                }
                else
                {
                    skinEngine1.Active = false;
                    theme = string.Empty;
                }
                Th1 = f5.GetTh1();
                Th2 = f5.GetTh2();
                Th3 = f5.GetTh3();
                Th4 = f5.GetTh4();
                //Th5 = f5.GetTh5();
                Th6 = f5.GetTh6();
            }
            else
            {
                ConfigureForm f5 = new ConfigureForm(Th1, Th2, Th3, Th4, Th6);
                f5.ShowDialog();
                if (f5.GetzjljStart())
                {
                    GetzjljPath(f5.GetzjljInformation());
                }
                if (f5.GetsbljStart())
                {
                    GetsbljPath(f5.GetsbljInformation());
                }
                if (f5.GetxjljStart())
                {
                    GetxjljPath(f5.GetxjljInformation());
                }
                if (f5.GetTheme() != string.Empty)
                {
                    skinEngine1.Active = true;
                    theme = f5.GetTheme();
                    skinEngine1.SkinFile = Application.StartupPath + theme;
                }
                else
                {
                    skinEngine1.Active = false;
                    theme = string.Empty;
                }
                Th1 = f5.GetTh1();
                Th2 = f5.GetTh2();
                Th3 = f5.GetTh3();
                Th4 = f5.GetTh4();
                //Th5 = f5.GetTh5();
                Th6 = f5.GetTh6();
            }
        }

        private void ClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map1.FunctionMode = FunctionMode.Info;
        }

        private void GetzjljPath(string zjljpath)
        {
            this.Zjlj_Path = zjljpath;
        }

        private void GetsbljPath(string sbljpath)
        {
            this.Sblj_Path = sbljpath;
        }

        private void GetxjljPath(string xjljpath)
        {
            this.Xjlj_Path = xjljpath;
        }

        private void DbfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = null;

            if (Map1.Layers.Count > 0)
            {

                MapLineLayer stateLayer = default(MapLineLayer);
                int layerCount = 0;
                int aimLayerNum = 0;

                for (int i = 0; i < Map1.Layers.Count(); i++)
                {
                    if (Map1.Layers[i].IsSelected)
                    {
                        layerCount++;
                        aimLayerNum = i;
                    }
                    else
                    {
                        layerCount = layerCount + 0;
                    }
                }
                if (layerCount == 1)
                {
                    stateLayer = (MapLineLayer)Map1.Layers[aimLayerNum];

                    //Get the shapefile's attribute table to our datatable dt
                    dt = stateLayer.DataSet.DataTable;

                    AttributeTableForm atf = new AttributeTableForm();
                    atf.Show();
                    //Set the datagridview datasource from datatable dt
                    atf.dgvAttributeTable.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("没有选择图层");
                }
            }
            else
            {
                MessageBox.Show("请加入一个图层");
            }
        }

        private void SQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQL_search sql_searchForm = new SQL_search();
            sql_searchForm.ShowDialog();
            if (sql_searchForm.GetStart())
            {
                try
                {
                    if (Map1.Layers[0] is MapLineLayer)
                    {
                        try
                        {
                            ByAttributeSearch(sql_searchForm.GetInformation());
                        }
                        catch
                        {
                            MessageBox.Show("查询失败，请查看并根据属性表输入正确的查询语句\n例如 [ID] = 69 ");
                        }
                    }
                    else
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("请添加图层后再进行查询");
                }
                
            }
        }

        private void ByAttributeSearch(string s)
        {
            LineLayer layer1 = (MapLineLayer)Map1.Layers[0];
            layer1.SelectByAttribute(s);
            layer1.ZoomToSelectedFeatures();
        }

        private void DistanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PatternmeasureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapFunctionMeasure measure = new MapFunctionMeasure(Map1);
            if (!Map1.MapFunctions.Contains(measure))
                Map1.MapFunctions.Add(measure);
            Map1.FunctionMode = FunctionMode.None;
            Map1.Cursor = Cursors.Cross;
            measure.Activate();
        }

        private void tabMap_Click(object sender, EventArgs e)
        {

        }

        private void BuffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BufflineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LoadStart)
            {
                Line_hcSearch line_hcSearchForm = new Line_hcSearch();
                line_hcSearchForm.ShowDialog();
                if (line_hcSearchForm.GetStart())
                {
                    if (Map1.Layers[0] is MapLineLayer)
                    {
                        Linehq_Search(line_hcSearchForm.GetID(), line_hcSearchForm.GetRange());
                    }
                }
            }
            else
            {
                MessageBox.Show("请先预加载数据");
            }
        }

        private void Linehq_Search(int id, double range)
        {
            List<int> tempid = new List<int>();
            double xmax = polylines[id].Box[3];
            double xmin = polylines[id].Box[1];
            double ymax = polylines[id].Box[2];
            double ymin = polylines[id].Box[0];
            double AimYmax = polylines[id].Box[2] + range;
            double AimYmin = polylines[id].Box[0] - range;
            double AimXmin = polylines[id].Box[1] - range;
            double AimXmax = polylines[id].Box[3] + range;
            double AimWidth = AimYmax - AimYmin;
            double AimLength = AimXmax - AimXmin;
            string s = "";
            LineLayer layer1 = (MapLineLayer)Map1.Layers[0];

            for (int i = 0; i < polylines.Count(); i++)
            {
                double newXmax = polylines[i].Box[3];
                double newYmax = polylines[i].Box[2];
                double newXmin = polylines[i].Box[1];
                double newYmin = polylines[i].Box[0];
                double newWidth = newYmax - newYmin;
                double newLength = newXmax - newXmin;

                double totalXmax;
                double totalXmin;
                double totalYmax;
                double totalYmin;
                double totalWidth;
                double totalLength;

                if (AimYmax > newYmax) { totalYmax = AimYmax; }
                else totalYmax = newYmax;
                if (AimYmin > newYmin) { totalYmin = newYmin; }
                else totalYmin = AimYmin;
                if (AimXmax > newXmax) { totalXmax = AimXmax; }
                else totalXmax = newXmax;
                if (AimXmin > newXmin) { totalXmin = newXmin; }
                else totalXmin = AimXmin;
                totalWidth = totalYmax - totalYmin;
                totalLength = totalXmax - totalXmin;

                if ((newWidth + AimWidth > totalWidth) && (newLength + AimLength > totalLength)) { tempid.Add(i); }
            }
            for (int i = 0; i < tempid.Count(); i++)
            {
                if (s == "")
                {
                    s = "[ID] = " + Convert.ToString(tempid[0]);
                }
                else
                {
                    s = s + " or " + "[ID] = " + Convert.ToString(tempid[i]);
                }
            }
            layer1.SelectByAttribute(s);
        }

        private void LoadtoolStripButton1_Click(object sender, EventArgs e)
        {
            string shpfilepath = "";
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                shpfilepath = ofd.FileName;
                BinaryReader br = new BinaryReader(ofd.OpenFile());
                br.ReadBytes(24);
                int FileLength = br.ReadInt32();//代表数据长度未知
                int FileBanben = br.ReadInt32();
                ShapeType = br.ReadInt32();
                xmin = br.ReadDouble();
                ymax = br.ReadDouble();
                xmax = br.ReadDouble();
                ymin = br.ReadDouble();
                double width = xmax - xmin;
                double height = ymax - ymin;
                br.ReadBytes(32);

                switch (ShapeType)
                {
                    case 1:
                        points.Clear();
                        while (br.PeekChar() != -1)
                        {
                            shpclass.Point point = new shpclass.Point();
                            uint RecordNum = br.ReadUInt32();
                            int DataLength = br.ReadInt32();
                            br.ReadInt32();
                            point.X = br.ReadDouble();
                            point.Y = -1 * br.ReadDouble();
                            points.Add(point);
                        }

                        break;
                    case 3:
                        polylines.Clear();
                        while (br.PeekChar() != -1)
                        {
                            shpclass.Polyline polyline = new shpclass.Polyline();
                            polyline.Box = new double[4];
                            polyline.Parts = new ArrayList();
                            polyline.Points = new ArrayList();
                            uint RecordNum = br.ReadUInt32();
                            int DataLength = br.ReadInt32();
                            //读取第i个记录
                            br.ReadInt32();
                            polyline.Box[0] = br.ReadDouble();
                            polyline.Box[1] = br.ReadDouble();
                            polyline.Box[2] = br.ReadDouble();
                            polyline.Box[3] = br.ReadDouble();
                            polyline.NumParts = br.ReadInt32();
                            polyline.NumPoints = br.ReadInt32();
                            for (int i = 0; i < polyline.NumParts; i++)
                            {
                                int parts = new int();
                                parts = br.ReadInt32();
                                polyline.Parts.Add(parts);
                            }
                            for (int j = 0; j < polyline.NumPoints; j++)
                            {
                                shpclass.Point pointtemp = new shpclass.Point();
                                pointtemp.X = br.ReadDouble();
                                pointtemp.Y = br.ReadDouble();
                                polyline.Points.Add(pointtemp);
                            }
                            polylines.Add(polyline);
                        }
                        break;
                }
                LoadStart = true;
            }
        }
    }
}
