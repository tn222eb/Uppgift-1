using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]

           public void TriangleTypesTest()
        {
            // Förväntar mig att det ska bli true
            Triangle triangleTest1 = new Triangle(0.3, 0.2, 0.5);
            Assert.IsTrue(triangleTest1.isScalene());

            // Förväntar mig att det ska bli false
            Triangle triangleTest2 = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(triangleTest2.isScalene());

            // Förväntar mig att det ska bli true
            Triangle triangleTest3 = new Triangle(1.0, 0.5, 1.0);
            Assert.IsTrue(triangleTest3.isIsosceles());

            // Förväntar mig att det ska bli false
            Triangle triangleTest4 = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(triangleTest4.isIsosceles());

            // Förväntar mig att det ska bli true
            Triangle triangleTest5 = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(triangleTest5.isEquilateral());

            // Förväntar mig att det ska bli false
            Triangle triangleTest6 = new Triangle(2.0, 0.6, 0.4);
            Assert.IsTrue(triangleTest6.isEquilateral());
        }
            
    }
}
