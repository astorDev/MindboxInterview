namespace Mindbox.Figures.Triangles
{
    public class TrianglesFactory
    {
        public Triangle Create(double a, double b, double c)
        {
            var sides = new Sides(a, b, c);

            return sides.IsOfRightTriangle ? new RightTriangle(sides) : new Triangle(sides);
        }
    }
}