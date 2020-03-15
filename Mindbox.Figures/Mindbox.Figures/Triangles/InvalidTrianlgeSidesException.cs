using System;

namespace Mindbox.Figures.Triangles
{
    public class InvalidTriangleSidesException : Exception
    {
        public override string Message => "Сторона треугольника не может быть больше суммы двух других сторон";
    }
}