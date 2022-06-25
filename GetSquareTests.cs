using System;
using System.Collections.Generic;
using System.Text;
using MindBox___test;
using Xunit;

namespace MindBoxTests
{
    public class GetSquareTests
    {
        [Fact]
        public void SquareCircleTest()
        {
            var GetCicleSquare = new GetCircleSquare();

            var result = GetSquare.GetS(GetCicleSquare, 5);

            Assert.Equal(78,(int)result);
        }

        [Fact]
        public void SquareTriangleTest()
        {
            var GetTriangleSquare = new GetTriangleSquare();

            var result = GetSquare.GetS(GetTriangleSquare, 12,13,5);

            Assert.Equal(30, (int)result);
        }

    }
}
