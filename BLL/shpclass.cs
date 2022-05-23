﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SGEDSystem
{
    class shpclass
    {
        public class Point//点类
        {
            public double X;
            public double Y;
        }

        public class Polyline//线类
        {
            public double[] Box = new double[4];
            public int NumParts;
            public int NumPoints;
            public ArrayList Parts;//在部分中第一个点的索引
            public ArrayList Points;//所有部分的点
        }

        public class Polygon : Polyline//面类
        { }
    }
}
