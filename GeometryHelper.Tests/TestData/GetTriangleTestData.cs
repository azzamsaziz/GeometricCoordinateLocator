using System.Collections;
using System.Collections.Generic;

namespace GeometryHelper.Tests.TestData
{
    public class GetTriangleTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new Coordinate[]
            {
                new Coordinate
                {
                    X = 1,
                    Y = 1
                }
            };
            yield return new Coordinate[]
            {
                new Coordinate
                {
                    X = 1,
                    Y = 1
                }
            };
            yield return new Coordinate[]
            {
                new Coordinate
                {
                    X = 1,
                    Y = 1
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
