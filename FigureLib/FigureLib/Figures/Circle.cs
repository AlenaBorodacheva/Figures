using FigureLib.Abstracts;

namespace FigureLib.Figures
{
    public class Circle : Shape
    {
        public Circle(double radius) : base(radius)
        {
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
