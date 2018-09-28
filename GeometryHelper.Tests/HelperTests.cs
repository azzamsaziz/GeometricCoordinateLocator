using GeometryHelper.Tests.TestData;
using System.Collections.Generic;
using Xunit;

namespace GeometryHelper.Tests
{
    public class HelperTests
    {
        [Theory]
        [ClassData(typeof(GetTriangleTestData))]
        public void GetTriangle_GivenCoordinates_ReturnsTriangles(ICollection<Coordinate> coordinates)
        {
            // Arrange

            // Act

            // Assert
        }

        [Fact]
        public void GetTriangle_GivenInvalidCoordinates_ThrowsException()
        {
            // Arrange

            // Act

            // Assert
        }

        [Theory]
        [ClassData(typeof(GetCoordinatesData))]
        public void GetCoordinates_GivenRowAndColumn_ReturnsCoordinates(int row, int column, ICollection<Coordinate> expectedCoordinates)
        {
            // Act
            var result = Helper.GetCoordinates(row, column);

            // Assert
            Assert.Equal(expectedCoordinates, result);
        }

        [Fact]
        public void GetCoordinates_GivenInvalidRowAndColumn_ThrowsException()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}