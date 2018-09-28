using System.Collections.Generic;
using GeometryHelper.Interfaces;

namespace GeometryHelper.Models
{
    public class Triangle : IShape
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public IEnumerable<Coordinate> Coordinates { get; set; } = new List<Coordinate>();
        public ShapeType Shape { get; set; } = ShapeType.Triangle;
    }
}