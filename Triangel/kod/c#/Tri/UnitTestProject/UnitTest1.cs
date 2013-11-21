using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]

           public void isIsoscelesthreeDoubles()
        {
            // Förväntar mig att det ska bli true eftersom gett rätt värde till en likbent triangel
            Triangle triangleTest3 = new Triangle(1.0, 2.0, 1.0);
            Assert.IsTrue(triangleTest3.isIsosceles());

        }
        [TestMethod]

        public void isIsoscelesDoubleArray()
        {
            // Förväntar mig att det ska bli true eftersom gett rätt värde till en likbent triangel
            Triangle triangleTest3 = new Triangle(new double []{ 1.0, 2.0, 1.0});
            Assert.IsTrue(triangleTest3.isIsosceles());

        }

        [TestMethod]
        public void isScalenePoint()
        { 
            Point a = new Point(12, 15);
            Point b = new Point(13, 17);
            Point c = new Point(10, 12);
            Triangle Triangletestnew = new Triangle(a, b, c);
            Assert.IsTrue(Triangletestnew.isScalene());
        }

        [TestMethod]

        public void isScalenePointArray()
        { 
            Point a = new Point(12, 15);
            Point b = new Point(13, 17);
            Point c = new Point(10, 12);
            Triangle triangleTestArray = new Triangle(new Point[] { a, b, c });
            Assert.IsTrue(triangleTestArray.isScalene());
        }

        [TestMethod]

        public void isIsosceles2()
        {

            // Förväntar mig att det ska bli true eftersom gett rätt värde till en likbent triangel
            Triangle triangleTest4 = new Triangle(1.0, 0.0, 1.0);
            Assert.IsTrue(triangleTest4.isIsosceles());

        }


        [TestMethod]

        public void isEquilateral()
        {
            // Förväntar mig att det ska bli false eftersom gett fel värde till en triangel med olika sidor
            Triangle triangleTest2 = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(triangleTest2.isEquilateral());
        }

        [TestMethod]

        public void isScalene2()
        {
            // Förväntar mig att det ska bli true eftersom gett rätt värde till en triangel med olika sidor
            Triangle triangleTest1 = new Triangle(0.5, 0.2, 0.3);
            Assert.IsTrue(triangleTest1.isScalene());
        }

        [TestMethod]

        public void isScalene()
        {
            // Förväntar mig att det ska bli false eftersom gett fel värde till en liksidig triangel
            Triangle triangleTest6 = new Triangle(2.0, 0.6, 0.4);
            Assert.IsTrue(triangleTest6.isScalene());
        }
            
    }
}
