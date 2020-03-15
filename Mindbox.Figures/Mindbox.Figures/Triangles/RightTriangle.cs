using System.Collections.Generic;

namespace Mindbox.Figures.Triangles
{
    public class RightTriangle : Triangle
    {
        public double Hypotenuse { get; }
        
        public IReadOnlyList<double> Legs { get; }

        public override double Area => this.Legs[0] * this.Legs[1] / 2;

        internal RightTriangle(Sides sides) : base(sides)
        {
            this.Hypotenuse = sides.Biggest;
            this.Legs = sides.ExceptBiggest;
        }
    }
}