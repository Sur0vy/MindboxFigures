using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MindboxFigures.Tests
{
    [TestClass]
    public class FiguresTests
    {
        [TestMethod]
        public void Triangle_Area_3_4_5_6Returned()
        {
        //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            //act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_Exist_5_6_3_TrueReturned()
        {
            //arrange
            double a = 5;
            double b = 6;
            double c = 3;
            Boolean expected = true;

            //act
            Triangle triangle = new Triangle(a, b, c);
            Boolean actual = triangle.Exist();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_NotExist_1_2_3_FalseReturned()
        {
            //arrange
            double a = 1;
            double b = 2;
            double c = 3;
            Boolean expected = false;

            //act
            Triangle triangle = new Triangle(a, b, c);
            Boolean actual = triangle.Exist();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_Perimeter_5_9_12_26Returned()
        {
            //arrange
            double a = 5;
            double b = 9;
            double c = 12;
            double expected = 26;

            //act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetPerimeter();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_IsRight_3_4_5_TrueReturned()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            Boolean expected = true;

            //act
            Triangle triangle = new Triangle(a, b, c);
            Boolean actual = triangle.IsRight();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_IsRight_3_4_5_FalseReturned()
        {
            //arrange
            double a = 4;
            double b = 4;
            double c = 5;
            Boolean expected = false;

            //act
            Triangle triangle = new Triangle(a, b, c);
            Boolean actual = triangle.IsRight();

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Circle_Area_3_6Returned()
        {
            //arrange
            double r = 3;
            double expected = Math.PI * 9;

            //act
            Circle circle = new Circle(r);
            double actual = circle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Circle_Exist_4_TrueReturned()
        {
            //arrange
            double r = 4;
            Boolean expected = true;

            //act
            Circle circle = new Circle(r);
            Boolean actual = circle.Exist();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Circle_Exist_minus1_FalseReturned()
        {
            //arrange
            double r = -1;
            Boolean expected = false;

            //act
            Circle circle = new Circle(r);
            Boolean actual = circle.Exist();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
