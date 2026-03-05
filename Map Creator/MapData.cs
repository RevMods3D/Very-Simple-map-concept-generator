using System;
using System.Collections.Generic;
using System.Text;

namespace Map_Creator
{
    internal class MapData
    {
        public string Name { get; set; }
        public List<Point> Points { get; set; }
        public List<Point> Clusters { get; set; }

        public MapData()
        {
            Name = "";
            Points = [];
            Clusters = [];
        }
    }
}
