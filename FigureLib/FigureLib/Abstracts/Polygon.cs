using FigureLib.Abstracts.Interfaces;

namespace FigureLib.Abstracts
{
    public abstract class Polygon : IFigure
    {
        public double[] Sides { get; }

        protected Polygon(double[] sides)
        {
            Sides = sides;
        }

        public abstract double GetArea();
        public double GetPerimeter() => Sides.Sum();
    }
}
