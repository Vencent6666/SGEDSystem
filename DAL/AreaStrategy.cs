using DotSpatial.Topology;
using System.Collections.Generic;

namespace Map4_0
{
    public abstract class AreaStrategy
    {
        public abstract List<double> Polygon(List<Line> line_list);
    }
}