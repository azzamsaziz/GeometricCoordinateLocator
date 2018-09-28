using System.Collections;
using System.Collections.Generic;

namespace GeometryHelper.Tests.TestData
{
    public class GetInvalidTriangleTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<Coordinate>()
            };
            yield return new object[]
            {
                new List<Coordinate>
                {
                    new Coordinate
                    {
                        X = -1,
                        Y = 1
                    },
                    new Coordinate
                    {
                        X = 1,
                        Y = 1
                    },
                    new Coordinate
                    {
                        X = 1,
                        Y = 1
                    }
                }
            };
            yield return new object[]
            {
                new List<Coordinate>
                {
                    new Coordinate
                    {
                        X = 1,
                        Y = -1
                    },
                    new Coordinate
                    {
                        X = 1,
                        Y = 1
                    },
                    new Coordinate
                    {
                        X = 1,
                        Y = 1
                    }
                }
            };
            yield return new object[]
            {
                new List<Coordinate>
                {
                    new Coordinate
                    {
                        X = 1,
                        Y = 1
                    },
                    new Coordinate
                    {
                        X = 1,
                        Y = -1
                    },
                    new Coordinate
                    {
                        X = 1,
                        Y = 1
                    }
                }
            };
            yield return new object[]
            {
                new List<Coordinate>
                {
                    new Coordinate
                    {
                        X = 1,
                        Y = 1
                    },
                    new Coordinate
                    {
                        X = 1,
                        Y = 1
                    },
                    new Coordinate
                    {
                        X = 1,
                        Y = -1
                    }
                }
            };
            yield return new object[]
            {
                new List<Coordinate>
                {
                    new Coordinate
                    {
                        X = 1,
                        Y = -1
                    }
                }
            };
            yield return new object[]
            {
                new List<Coordinate>
                {
                    new Coordinate
                    {
                        X = 1,
                        Y = -1
                    },
                    new Coordinate
                    {
                        X = 1,
                        Y = 1
                    }
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}