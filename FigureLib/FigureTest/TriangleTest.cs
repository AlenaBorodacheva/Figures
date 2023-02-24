using System;
using FigureLib.Figures;
using Xunit;

namespace FigureTest
{
    public class TriangleTest
    {
        private const double Eps = 1E-5;

        [Fact]
        public void CreateTriangleWithLessZeroSideTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(5, 6, -2));
        }

        [Fact]
        public void CreateUnrealTriangleTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(4, 8, 15));
        }

        [Fact]
        public void CreateRealTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var area = triangle.GetArea();
            Assert.True(Math.Abs(6 - area) <= Eps);
        }

        [Fact]
        public void CreateRightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void CreateNotRightTriangleTest()
        {
            Triangle triangle = new Triangle(2, 2, 3);
            Assert.False(triangle.IsRight());
        }
    }
}
