using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mindbox.Figures.Triangles
{
    public class Sides : IReadOnlyList<double>
    {
        private readonly double[] innerArray;
        public double Biggest { get; }
        public IReadOnlyList<double> ExceptBiggest { get; }
        
        public int Count => this.innerArray.Length;
        public double this[int index] => this.innerArray[index];
        
        public bool IsOfRightTriangle => Math.Abs(Math.Pow(this.Biggest, 2) -
                                                  (Math.Pow(this.ExceptBiggest[0], 2) +
                                                   Math.Pow(this.ExceptBiggest[1], 2))) < 0.0000001;
        
        public Sides(double a, double b, double c)
        {
            this.innerArray = new[] {a, b, c};
            this.Biggest = this.innerArray.Max();
            
            var list = this.innerArray.ToList();
            list.Remove(this.Biggest);
            this.ExceptBiggest = list;
            
            this.ThrowIfInvalidForTriangle();
        }
        
        public void ThrowIfInvalidForTriangle()
        {
            if (this.Biggest > this.ExceptBiggest.Sum())
            {
                throw new InvalidTriangleSidesException();
            }
        }
        
        public IEnumerator<double> GetEnumerator()
        {
            return ((IEnumerable<double>) this.innerArray).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}