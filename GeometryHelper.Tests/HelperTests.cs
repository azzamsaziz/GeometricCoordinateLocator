using GeometryHelper.Tests.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GeometryHelper.Tests
{
    public class HelperTests
    {
        [Theory]
        [ClassData(typeof(GetTriangleTestData))]
        public void GetTriangle_GivenCoordinates_ReturnsTriangles(ICollection<Coordinate> coordinates, int row, int column)
        {
            // Act
            var result = TriangleHelper.GetTriangle(coordinates);

            // Assert
            Assert.Equal(row, result.Row);
            Assert.Equal(column, result.Column);
        }

        [Theory]
        [ClassData(typeof(GetInvalidTriangleTestData))]
        public void GetTriangle_GivenInvalidCoordinates_ThrowsArgumentException(IEnumerable<Coordinate> coordinates)
        {
            // Act - Assert
            Assert.Throws<ArgumentException>(() => TriangleHelper.GetTriangle(coordinates));
        }

        [Theory]
        [ClassData(typeof(GetCoordinatesTestData))]
        public void GetCoordinates_GivenRowAndColumn_ReturnsCoordinates(int row, int column, ICollection<Coordinate> expectedCoordinates)
        {
            // Act
            var result = TriangleHelper.GetCoordinates(row, column);

            // Assert
            Assert.Equal(expectedCoordinates.Count, result.Count());
            for (int i = 0; i < expectedCoordinates.Count; i++)
            {
                Assert.Equal(expectedCoordinates.ElementAt(i).X, result.ElementAt(i).X);
                Assert.Equal(expectedCoordinates.ElementAt(i).Y, result.ElementAt(i).Y);
            }
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(-1, 1)]
        [InlineData(1, 0)]
        [InlineData(1, -1)]
        public void GetCoordinates_GivenInvalidRowOrColumn_ThrowsArgumentException(int row, int column)
        {
            // Act - Assert
            Assert.Throws<ArgumentException>(() => TriangleHelper.GetCoordinates(row, column));
        }
    }
}