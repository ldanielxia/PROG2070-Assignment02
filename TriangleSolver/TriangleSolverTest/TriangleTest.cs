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
        //Five (5) tests for a valid scalene triangle

        [Test]
        public void ValidTriangle_Input50and60and70_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstAngel = 50;
            int secondAngel = 60;
            int thirdAngle = 70;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input80and65and78_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstAngel = 80;
            int secondAngel = 65;
            int thirdAngle = 78;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input80and95and78_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstAngel = 80;
            int secondAngel = 95;
            int thirdAngle = 78;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input68and75and80_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstAngel = 68;
            int secondAngel = 75;
            int thirdAngle = 80;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input75and78and79_OutputValidScaleneTriangle()
        {
            //Arrange
            int firstAngel = 75;
            int secondAngel = 78;
            int thirdAngle = 79;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }

        //Three (3) tests for verifying a zero length for one or more sides
        [Test]
        public void ValidTriangle_Input0and60and70_OutputValidHasAZeroTriangle()
        {
            //Arrange
            int firstAngel = 0;
            int secondAngel = 60;
            int thirdAngle = 70;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input0and0and60_OutputValidHasAZeroTriangle()
        {
            //Arrange
            int firstAngel = 0;
            int secondAngel = 0;
            int thirdAngle = 60;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ValidTriangle_Input0and0and0_OutputValidHasAZeroTriangle()
        {
            //Arrange
            int firstAngel = 0;
            int secondAngel = 0;
            int thirdAngle = 0;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);

        }

        //Three (3) tests for verifying an invalid response (other than a zero length)

        [Test]
        public void ValidTriangle_Input10and11and23_OutputValidINVALIDTriangle()
        {
            //Arrange
            int firstAngel = 10;
            int secondAngel = 11;
            int thirdAngle = 23;

            string expected = "Based on the values entered, the triangle is INVALID";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_Input45and11and23_OutputValidINVALIDTriangle()
        {
            //Arrange
            int firstAngel = 45;
            int secondAngel = 11;
            int thirdAngle = 23;

            string expected = "Based on the values entered, the triangle is INVALID";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidTriangle_Input21and11and94_OutputValidINVALIDTriangle()
        {
            //Arrange
            int firstAngel = 21;
            int secondAngel = 11;
            int thirdAngle = 94;

            string expected = "Based on the values entered, the triangle is INVALID";
            //Art
            String actual = new Triangle().AnalyzeTriangle(firstAngel, secondAngel, thirdAngle);

            Assert.AreEqual(expected, actual);
        }
    }
}