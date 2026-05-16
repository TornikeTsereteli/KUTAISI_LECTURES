namespace Interfaces.Abstract;

public class Prism
{
    
    private double _height;
    private GeometryFigure _base;

    public Prism(double height, GeometryFigure geometryFigure)
    {
        _height = height;
        _base = geometryFigure;

    }

    public double SurfaceArea()
    {
        return _base.Perimeter() * _height + 2 * _base.Area(); 
    }
    
    public double Volume()
    {
        var baseArea = _base.Area();
        return baseArea * _height;
    }
}