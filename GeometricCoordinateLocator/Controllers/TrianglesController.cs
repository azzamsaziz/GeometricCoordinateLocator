using GeometryHelper;
using GeometryHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GeometricCoordinateLocator.Controllers
{
    [Route("api/[controller]")]
    public class TrianglesController : Controller
    {
        // GET /api/triangles/?topEdge.X=0&topEdge.Y=30&rightEdge.X=0&rightEdge.Y=20&leftEdge.X=10&leftEdge.Y=30
        [HttpGet()]
        [ProducesResponseType(200)]
        public Triangle Get(Coordinate topEdge, Coordinate rightEdge, Coordinate leftEdge)
        {
            var input = new List<Coordinate>
            {
                topEdge,
                rightEdge,
                leftEdge
            };

            return TriangleHelper.GetTriangle(input);
        }

        // GET api/triangles/{row}/{column}
        [HttpGet("{row}/{column:int}")]
        [ProducesResponseType(200)]
        public IEnumerable<Coordinate> Get(char row, int column)
        {
            if (!Char.IsLetter(row))
                throw new ArgumentException($"The {nameof(row)} argument does not contain a valid letter.");
            if (column < 0)
                throw new ArgumentException($"The {nameof(column)} argument is invalid. Please provide positive integers.");

            // Get the ASCII value of a character, -64 to normalize the integer to base 1
            var rowIntegerRepresentation = Char.ToUpper(row) - 64;

            return TriangleHelper.GetCoordinates(rowIntegerRepresentation, column);
        }
    }
}