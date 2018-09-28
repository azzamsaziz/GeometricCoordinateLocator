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
        IList<Coordinate> Coordinates { get; set; }
        ShapeType Shape { get; set; }
    }
}