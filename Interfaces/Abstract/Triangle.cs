using Interfaces.Validation;

namespace Interfaces.Abstract;

public class Triangle : GeometryFigure
{
    private double _sideA;
    private double _sideB;
    private double _sideC;
    
    
    public Triangle(double sideA, double sideB, double sideC) : base("Triangle")
    {
        TriangleValidation.Validate(sideA, sideB, sideC);
        
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public override double Area()
    {
        double s = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(s * (s - _sideA) * (s - _sideB) * (s - _sideC));
    }

    public override double Perimeter()
    {
        return _sideA + _sideB + _sideC;
    }
    
    
    
}