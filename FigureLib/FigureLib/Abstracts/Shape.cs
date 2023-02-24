using FigureLib.Abstracts.Interfaces;

namespace FigureLib.Abstracts
{
    public abstract class Shape : IFigure
    {
        public double Radius { get; }

        protected Shape(double radius)
        {
            Radius = radius;
        }

        public abstract double GetArea();
    }
}
