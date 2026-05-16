namespace Interfaces.Abstract;

public abstract class GeometryFigure
{
    public string Name { get; private set; }
    
    public GeometryFigure(string name)
    {
        this.Name = name;
    }
    
    
    public abstract double Area();
    public abstract double Perimeter();
}