using GeometryHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeometryHelper
{
    public static class TriangleHelper
    {
        public static Triangle GetTriangle(IEnumerable<Coordinate> coordinates)
        {
            if (coordinates == null || !coordinates.Any())
                throw new ArgumentException($"The parameter {nameof(coordinates)} is not valid. Please provide a non-empty list of coordinates.");
            if (coordinates.Count() < 3)
                throw new ArgumentException($"The parameter {nameof(coordinates)} is not valid. Please provide three coordinates.");
            if (coordinates.Any(coordinate => coordinate.X < 0 || coordinate.Y < 0))
                throw new ArgumentException($"The parameter {nameof(coordinates)} is not valid. Please provide positive coordinates.");

            // Facing down
            if (coordinates.First().Y > coordinates.ElementAt(1).Y)
            {
                // Top
                return new Triangle
                {
                    Column = (coordinates.First().X / 5) + 1,
                    Row = coordinates.First().Y / 10,
                    Coordinates = coordinates
                };
            }
            else if (coordinates.First().Y < coordinates.ElementAt(1).Y) // Facing up
            {
                return new Triangle
                {
                    Column = coordinates.First().X / 5,
                    Row = (coordinates.First().Y / 10) + 1,
                    Coordinates = coordinates
                };
            }

            throw new InvalidOperationException("The coordinates provided are not valid.");
        }

        public static IEnumerable<Coordinate> GetCoordinates(int row, int column)
        {
            if (row <= 0)
                throw new ArgumentException($"The parameter {nameof(row)} is not valid. Please provide a positive integer.");
            else if (column <= 0)
                throw new ArgumentException($"The parameter {nameof(column)} is not valid. Please provide a positive integer.");

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