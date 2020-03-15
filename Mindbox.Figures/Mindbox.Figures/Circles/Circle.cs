using System;

namespace Mindbox.Figures.Circles
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public double Area => Math.PI * Math.Pow(this.Radius, 2);
        
        public Circle(double radius)
        {
            this.Radius = radius;
        }
    }
}