using DotSpatial.Topology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDSystem
{
    class Circle
    {
        public double CenterX { get; set; }   //圆心X坐标
        public double CenterY { get; set; }   //圆心Y坐标
        public double Radius { get; set; }   //圆半径
        public List<Coordinate> Points = new List<Coordinate>(); //所有部分的点
        public int NumPoints { get; set; }
        public double Contour { get; set; }
        public int Id { get; set; }
        public int Group { get; set; }
        public double Grade { get; set; }
        public double Area { get; set; }
        public bool Edge { get; set; }
        public double Height { get; set; }
        public double Slope { get; set; }

        public Circle(double CenterX,double CenterY,double Radius ,List<Coordinate> Points)   //构造函数
        {
            this.CenterX = CenterX;
            this.CenterY = CenterY;
            this.Radius = Radius;
            this.Points = Points;
            this.Group = 0;
            this.NumPoints = Points.Count;
            Area = 0;
            Edge = false;
        }

        public Circle(double CenterX, double CenterY, double Radius, List<Coordinate> Points,int Group,int Id, double Contour)   //构造函数
        {
            this.CenterX = CenterX;
            this.CenterY = CenterY;
            this.Radius = Radius;
            this.Points = Points;
            this.Group = Group;
            this.Id = Id;
            this.Contour = Contour;
            this.NumPoints = Points.Count;
            Area = 0;
            Edge = false;
        }

        public Circle(int NumPoints, List<Coordinate> Points, double contour)
        {
            this.NumPoints = NumPoints;
            this.Points = Points;
            this.Contour = contour;
        }

        public Circle()
        {

        }

        public void Add(Coordinate poi)
        {
            Points.Add(poi);
        }

        public Circle Clone()
        {

            this.Group = 0;
            this.NumPoints = Points.Count;
            Circle clone = new Circle(this.CenterX, this.CenterY, this.Radius, this.Points,this.Group,this.Id,this.Contour);
            clone.Area = this.Area;
            return clone;
        }
    }
}
