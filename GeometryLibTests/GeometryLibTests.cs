using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLib;
using System;

namespace GeometryLibTests
{
  [TestClass]
  public class GeometryLibTests
  {
    [TestMethod]
    public void TestCircleArea()
    {
      // Arrange
      double radius = 5;
      Circle circle = new Circle(radius);

      // Act
      double area = circle.CalculateArea();

      // Assert
      Assert.AreEqual(Math.PI * radius * radius, area);
    }

    [TestMethod]
    public void Constructor_ShouldCreateTriangle_ForValidTriangle()
    {
      // Arrange
      double a = 3.0;
      double b = 4.0;
      double c = 5.0;

      // Act
      Triangle triangle = new Triangle(a, b, c);

      // Assert
      Assert.IsNotNull(triangle);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Constructor_ShouldThrowArgumentException_ForInvalidTriangle()
    {
      // Arrange
      double a = 5.0;
      double b = 1.0;
      double c = 10.0;

      // Act
      Triangle triangle = new Triangle(a, b, c);

      // Assert
      // Is handled by ExpectedException attribute
    }

    [TestMethod]
    public void TestTriangleArea()
    {
      // Arrange
      double sideA = 3;
      double sideB = 4;
      double sideC = 5;
      Triangle triangle = new Triangle(sideA, sideB, sideC);

      // Act
      double area = triangle.CalculateArea();

      // Assert
      Assert.AreEqual(6, area);
    }

    [TestMethod]
    public void GetIsRightAngled_ShouldReturnTrue()
    {
      // Arrange
      double a = 2.5;
      double b = 6.0;
      double c = 6.5;
      Triangle triangle = new Triangle(a, b, c);

      // Act
      bool result = triangle.GetIsRightAngled();

      // Assert
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void GetIsRightAngled_ShouldReturnFalse()
    {
      // Arrange
      double a = 3.5;
      double b = 4.5;
      double c = 6.0;
      Triangle triangle = new Triangle(a, b, c);

      // Act
      bool result = triangle.GetIsRightAngled();

      // Assert
      Assert.IsFalse(result);
    }
  }
}
