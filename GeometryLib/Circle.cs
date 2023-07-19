using System;

namespace GeometryLib
{
  /// <summary>
  /// The Circle class represents a simple circle.
  /// </summary>
  public class Circle : IShape
  {
    private double _radius;

    /// <summary>
    /// Creates a new instance of the circle with the given radius.
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    public Circle(double radius)
    {
      if (radius <= 0)
      {
        throw new ArgumentException(
          "Circle radius must be a positive non-zero value.");
      }

      _radius = radius;
    }

    /// <summary>
    /// Calculates and returns the area of the circle.
    /// </summary>
    /// <returns>The area of the circle.</returns>
    public double CalculateArea()
    {
      return Math.PI * _radius * _radius;
    }
  }
}
