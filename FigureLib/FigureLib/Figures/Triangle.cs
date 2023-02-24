using FigureLib.Abstracts;

namespace FigureLib.Figures
{
    public class Triangle : Polygon
    {
        public Triangle(double size1, double size2, double size3) : base(new[] { size1, size2, size3 })
        {
        }

        public override double GetArea()
        {
            var p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }

        public bool IsRight(double eps = 1E-5)
        {
            Array.Sort(Sides);
            return Math.Abs(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) - Math.Pow(Sides[2], 2)) <= eps;
        }
    }
}
