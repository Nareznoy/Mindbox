using System;

namespace GeometryLib
{
  /// <summary>
  /// The Triangle class represents a triangle.
  /// </summary>
  public class Triangle : IShape
  {
    private const double Epsilon = 0.0001;

    private double _sideA;
    private double _sideB;
    private double _sideC;

    /// <summary>
    /// Creates a new instance of the triangle with the given side lengths.
    /// </summary>
    /// <param name="sideA">The length of side A.</param>
    /// <param name="sideB">The length of side B.</param>
    /// <param name="sideC">The length of side C.</param>
    public Triangle(double sideA, double sideB, double sideC)
    {
      if (sideA <= 0 || sideB <= 0 || sideC <= 0)
      {
        throw new ArgumentException(
          "Triangle sides must be positive and non-zero.");
      }

      if (!GetIsValidTriangle(sideA, sideB, sideC))
      {
        throw new ArgumentException(
          "Invalid triangle sides. The sum of any two sides must be greater than the third side.");
      }

      _sideA = sideA;
      _sideB = sideB;
      _sideC = sideC;
    }

    /// <summary>
    /// Checks if a triangle with given side lengths is a valid triangle.
    /// </summary>
    /// <param name="a">The length of side A of the triangle.</param>
    /// <param name="b">The length of side B of the triangle.</param>
    /// <param name="c">The length of side C of the triangle.</param>
    /// <returns>True if the given side lengths form a valid triangle,
    /// where the sum of any two sides is greater than the third side, otherwise false.
    /// </returns>
    private bool GetIsValidTriangle(double a, double b, double c)
    {
      return a + b > c && a + c > b && b + c > a;
    }

    /// <summary>
    /// Calculates and returns the area of the triangle using the Heron's formula.
    /// </summary>
    /// <returns>The area of the triangle.</returns>
    public double CalculateArea()
    {
      double p = (_sideA + _sideB + _sideC) / 2;
      return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }

    /// <summary>
    /// Checks if the triangle is a right-angled triangle using the Pythagorean theorem.
    /// </summary>
    /// <returns>True if the triangle is right-angled, otherwise false.</returns>
    public bool GetIsRightAngled()
    {
      double[] sides = { _sideA, _sideB, _sideC };
      Array.Sort(sides);

      double hypotenuseSquared = Math.Pow(sides[2], 2);
      double otherSidesSumSquared = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);

      return Math.Abs(hypotenuseSquared - otherSidesSumSquared) < Epsilon;
    }
  }
}
