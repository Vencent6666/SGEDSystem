using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDSystem
{
    public class MBR
    {
        public double xmin { get; set; }
        public double xmax { get; set; }
        public double ymax { get; set; }
        public double ymin { get; set; }
        public double centerX { get; set; }
        public double centerY { get; set; }
        public double r { get; set; }

        public MBR(double xmin, double xmax, double ymax, double ymin)
        {
            this.xmin = xmin;
            this.xmax = xmax;
            this.ymax = ymax;
            this.ymin = ymin;
            centerX = (xmin + xmax) / 2.0;
            centerY = (ymin + ymax) / 2.0;
            if ((xmax - xmin) > (ymax - ymin))
                r = (ymax - ymin) / 2.0;
            else
                r = (xmax - xmin) / 2.0;

        }
    }
}
