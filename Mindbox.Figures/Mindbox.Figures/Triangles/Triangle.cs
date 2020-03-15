using System;
using System.Linq;

namespace Mindbox.Figures.Triangles
{
    public class Triangle : IFigure
    {
        public Sides Sides { get; }
        public double A => this.Sides[0];
        public double B => this.Sides[1];
        public double C => this.Sides[2];
        public double Perimeter => this.Sides.Sum();
        public double SemiPerimeter => this.Perimeter / 2;
        public virtual double Area => Math.Sqrt(this.SemiPerimeter * (this.SemiPerimeter - this.A) * (this.SemiPerimeter - this.B) * (this.SemiPerimeter - this.C)) ;

        internal Triangle(Sides sides)
        {
            this.Sides = sides;
        }
    }
}