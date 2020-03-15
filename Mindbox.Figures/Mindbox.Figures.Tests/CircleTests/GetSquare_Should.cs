using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox.Figures.Circles;

namespace Mindbox.Figures.Tests.CircleTests
{
    [TestClass]
    public class Area_Should
    {
        [TestMethod]
        public void ReturnPi_ForRadiusOfOne()
        {
            var circle = new Circle(1);

            Assert.AreEqual(Math.PI, circle.Area);
        }

        [TestMethod]
        public void ReturnFourPi_ForRadiusOfTwo()
        {
            var circle = new Circle(2);
            
            Assert.AreEqual(Math.PI * 4, circle.Area);
        }
    }
}