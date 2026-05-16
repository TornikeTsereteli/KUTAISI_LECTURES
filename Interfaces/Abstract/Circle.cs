namespace Interfaces.Abstract;

public class Circle : GeometryFigure, IComparable<Circle>
{
    private double _radius;
    public Circle(double radius) : base("Circle")
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Invalid circle radius");
        }
        _radius = radius;
    }

    public override double Area()
    {
        return Math.PI * _radius * _radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * _radius;
    }

    public int CompareTo(Circle? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (other is null) return 1;
        return _radius.CompareTo(other._radius);
    }
}