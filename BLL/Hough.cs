using DotSpatial.Topology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDSystem
{
    class Hough
    {
        public double a { get; set; }
        public double b { get; set; }
        public double r { get; set; }
        public List<Coordinate> p;
        public int count { get; set; }
        public Hough(double x0, double y0, double Radius, List<Coordinate> Points)   //构造函数
        {
            a = x0;
            b = y0;
            r = Radius;
            p = Points;
            count = 1;
        }
    }
}
