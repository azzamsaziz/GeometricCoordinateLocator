using System.Collections;
using System.Collections.Generic;

namespace GeometryHelper.Tests.TestData
{
    public class GetCoordinatesData : IEnumerable<object[]>
    {
        // The data coordinates are put as TOP, RIGHT, then LEFT edge
        public IEnumerator<object[]> GetEnumerator()
        {
            // A1
            yield return new object[] { 1, 1, new List<Coordinate>
            {
                new Coordinate
                {
                    X = 0,
                    Y = 10
                },
                new Coordinate
                {
                    X = 0,
                    Y = 0
                },
                new Coordinate
                {
                    X = 10,
                    Y = 10
                }
            }}; // A2
            yield return new object[] { 1, 2, new List<Coordinate>
            {
                new Coordinate
                {
                    X = 10,
                    Y = 0
                },
                new Coordinate
                {
                    X = 10,
                    Y = 10
                },
                new Coordinate
                {
                    X = 0,
                    Y = 0
                }
            }}; // A3
            yield return new object[] { 1, 3, new List<Coordinate>
            {
                new Coordinate
                {
                    X = 10,
                    Y = 10
                },
                new Coordinate
                {
                    X = 10,
                    Y = 0
                },
                new Coordinate
                {
                    X = 20,
                    Y = 10
                }
            }}; // A4
            yield return new object[] { 1, 4, new List<Coordinate>
            {
                new Coordinate
                {
                    X = 20,
                    Y = 10
                },
                new Coordinate
                {
                    X = 20,
                    Y = 10
                },
                new Coordinate
                {
                    X = 10,
                    Y = 0
                }
            }}; // B1
            yield return new object[] { 2, 1, new List<Coordinate>
            {
                new Coordinate
                {
                    X = 0,
                    Y = 20
                },
                new Coordinate
                {
                    X = 0,
                    Y = 10
                },
                new Coordinate
                {
                    X = 10,
                    Y = 20
                }
            }}; // B2
            yield return new object[] { 2, 2, new List<Coordinate>
            {
                new Coordinate
                {
                    X = 10,
                    Y = 10
                },
                new Coordinate
                {
                    X = 10,
                    Y = 20
                },
                new Coordinate
                {
                    X = 0,
                    Y = 10
                }
            }}; // C1
            yield return new object[] { 3, 1, new List<Coordinate>
            {
                new Coordinate
                {
                    X = 0,
                    Y = 30
                },
                new Coordinate
                {
                    X = 00,
                    Y = 20
                },
                new Coordinate
                {
                    X = 10,
                    Y = 30
                }
            }}; // C2
            yield return new object[] { 3, 2, new List<Coordinate>
            {
                new Coordinate
                {
                    X = 10,
                    Y = 20
                },
                new Coordinate
                {
                    X = 10,
                    Y = 30
                },
                new Coordinate
                {
                    X = 0,
                    Y = 20
                }
            }}; // B3
            yield return new object[] { 2, 3, new List<Coordinate>
            {
                new Coordinate
                {
                    X = 10,
                    Y = 20
                },
                new Coordinate
                {
                    X = 10,
                    Y = 10
                },
                new Coordinate
                {
                    X = 20,
                    Y = 20
                }
            }}; // B4
            yield return new object[] { 2, 4, new List<Coordinate>
            {
                new Coordinate
                {
                    X = 20,
                    Y = 10
                },
                new Coordinate
                {
                    X = 20,
                    Y = 20
                },
                new Coordinate
                {
                    X = 10,
                    Y = 10
                }
            }};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}