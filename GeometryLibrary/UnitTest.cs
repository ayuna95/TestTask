using NUnit.Framework;
using GeometryLibrary;
using System;

namespace GeometryLibrary.Tests
{
    [TestFixture]
    public class GeometryCalculatorTests
    {
        [Test]
        public void CalculateCircleArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5.0;
            Circle circle = new Circle(radius);

            // Act
            double area = circle.CalculateArea();

            // Assert
           Assert.AreEqual(Math.PI * Math.Pow(radius, 2), area, 0.001);
        }

        [Test]
        public void CalculateTriangleArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(6.0, area, 0.001);
        }

        [Test]
        public void IsRightTriangle_ValidRightTriangle_ReturnsTrue()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRightTriangle);
        }
    }
}
