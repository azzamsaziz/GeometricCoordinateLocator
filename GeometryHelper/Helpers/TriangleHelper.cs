using GeometryHelper.Models;
using System;
using System.Collections.Generic;

namespace GeometryHelper
{
    public static class TriangleHelper
    {
        public static Triangle GetTriangle(int x, int y)
        {
            return new Triangle();
        }

        public static IEnumerable<Coordinate> GetCoordinates(int row, int column)
        {
            // Top
            var topEdge = new Coordinate
            {
                X = (column / 2) * 10,
                Y = row * 10
            };
            if (column % 2 == 0)
                topEdge.Y -= 10;

            // Right
            var rightEdge = new Coordinate
            {
                X = (column / 2) * 10,
                Y = (row - 1) * 10
            };
            if (column % 2 == 0)
                rightEdge.Y += 10;

            // Left
            var leftEdge = new Coordinate();

            if (column % 2 == 0)
                leftEdge.X = ((column / 2) - 1) * 10;
            else
                leftEdge.X = Convert.ToInt32(Math.Ceiling(column / 2.0)) * 10;

            leftEdge.Y = (row * 10);
            if (column % 2 == 0)
                leftEdge.Y -= 10;

            return new List<Coordinate>
            {
                topEdge,
                rightEdge,
                leftEdge
            };
        }
    }
}