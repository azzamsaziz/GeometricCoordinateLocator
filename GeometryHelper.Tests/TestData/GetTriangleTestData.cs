using System.Collections;
using System.Collections.Generic;

namespace GeometryHelper.Tests.TestData
{
    public class GetTriangleTestData : IEnumerable<object[]>
    {
        // The data coordinates are put as TOP, RIGHT, then LEFT edge
        public IEnumerator<object[]> GetEnumerator()
        {
            // A1
            yield return new object[] {new List<Coordinate>
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
            }, 1, 1};
            // A2
            yield return new object[] {new List<Coordinate>
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
            }, 1, 2};
            // A3
            yield return new object[] {new List<Coordinate>
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
            }, 1, 3};
            // A4
            yield return new object[] {new List<Coordinate>
            {
                new Coordinate
                {
                    X = 20,
                    Y = 0
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
            }, 1, 4};
            // B1
            yield return new object[] {new List<Coordinate>
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
            }, 2, 1};
            // B2
            yield return new object[] {new List<Coordinate>
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
            }, 2, 2};
            // C1
            yield return new object[] {new List<Coordinate>
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
            }, 3, 1};
            // C2
            yield return new object[] {new List<Coordinate>
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
            }, 3, 2};
            // B3
            yield return new object[] {new List<Coordinate>
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
            }, 2, 3};
            // B4
            yield return new object[] {new List<Coordinate>
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
            }, 2, 4};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
