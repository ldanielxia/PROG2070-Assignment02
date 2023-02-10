using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TriangleSolverTest
{
    [TestFixture]
    public class TriangleTest
    {
        //Only one (1) test for a valid equilateral triangle
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidEquilateralTriangle()
        {
            //Arrange
            int firstAngel = 60;
            int secondAngel = 60;
            int thirdAngle = 60;

            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }
        //Three (3) tests for a valid isosceles triangle
        [Test]
        public void ValidTriangle_Input60and60and70_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstAngel = 60;
            int secondAngel = 60;
            int thirdAngle = 70;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input70and60and60_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstAngel = 70;
            int secondAngel = 60;
            int thirdAngle = 60;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input60and70and60_OutputValidIsoscelesTriangle()
        {
            //Arrange
            int firstAngel = 60;
            int secondAngel = 70;
            int thirdAngle = 60;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }
    }
}
