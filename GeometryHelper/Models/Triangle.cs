using System.Collections.Generic;
using GeometryHelper.Interfaces;

namespace GeometryHelper.Models
{
    public class Triangle : IShape
    {
        public IList<Coordinate> Coordinates { get; set; } = new List<Coordinate>();
        public ShapeType Shape { get; set; } = ShapeType.Triangle;
    }
}