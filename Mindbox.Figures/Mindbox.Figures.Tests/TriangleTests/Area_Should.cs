using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox.Figures.Triangles;

namespace Mindbox.Figures.Tests.TriangleTests
{
    [TestClass]
    public class Area_Should
    {
        [TestMethod]
        public void BeSix_ForEgyptTriangle()
        {
            var triangle = new TrianglesFactory().Create(3, 4, 5);
            Assert.AreEqual(6, triangle.Area);
        }

        [TestMethod]
        public void BeTwenty_ForMirroredEgyptTriangle()
        {
            var triangle = new TrianglesFactory().Create(5, 5, 8);
            Assert.AreEqual(12, triangle.Area);
        }

        [TestMethod]
        public void BeZero_ForFlatTriangle()
        {
            var triangle = new TrianglesFactory().Create(2, 1, 1);
            Assert.AreEqual(0, triangle.Area);
        }
    }
}