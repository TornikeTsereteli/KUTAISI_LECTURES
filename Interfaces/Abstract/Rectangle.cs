namespace Interfaces.Abstract;

public class Rectangle : GeometryFigure
{
    private int _length;
    private int _width;
    
    public Rectangle(int length, int width) : base("Rectangle")
    {
        if (length <= 0 || width <= 0)
        {
            throw new ArgumentException("Invalid rectangle dimensions");
        }
        
        this._length = length;
        this._width = width;
    }

    public override double Area()
    {
        return _length * _width;
    }

    public override double Perimeter()
    {
        return 2 * (_length + _width);
    }
}