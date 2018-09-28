using System.Collections.Generic;

namespace GeometryHelper.Interfaces
{
    public enum ShapeType
    {
        Square,
        Triangle,
        Rectangle,
        Circle
    }

    public interface IShape
    {
        IEnumerable<Coordinate> Coordinates { get; set; }
        ShapeType Shape { get; set; }
    }
}