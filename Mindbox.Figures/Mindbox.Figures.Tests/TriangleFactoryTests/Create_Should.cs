using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox.Figures.Triangles;

namespace Mindbox.Figures.Tests.TriangleFactoryTests
{
    [TestClass]
    public class Create_Should
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleSidesException))]
        public void ThrowException_WhenOneSizeBiggerThenTwoOther()
        {
            new TrianglesFactory().Create(1, 1, 4);
        }

        [TestMethod]
        public void ReturnTriangle_WhenThereIsTwoBigSizes()
        {
            new TrianglesFactory().Create(4, 4, 1);
        }

        [TestMethod]
        public void ReturnRightTriangle_WhenAccordingSidesArePassed()
        {
            var triangle = new TrianglesFactory().Create(3, 4, 5);
            Assert.IsInstanceOfType(triangle, typeof(RightTriangle));
        }
    }
}