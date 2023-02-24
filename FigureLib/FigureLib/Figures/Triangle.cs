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
            throw new NotImplementedException();
        }
    }
}
