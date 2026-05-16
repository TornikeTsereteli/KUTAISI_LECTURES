using Interfaces.Abstract;

public class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        
        A a = new B("John", "Doe");
        
        a.Method();
        
        
        GeometryFigure circle = new Circle(5);

        Console.WriteLine(circle.Area());
        Console.WriteLine(circle.Perimeter());


        GeometryFigure triange = new Triangle(3, 4, 5);
        Console.WriteLine(triange.Area());
        Console.WriteLine(triange.Perimeter());
        
        
        GeometryFigure rectangle = new Rectangle(3, 4);
        Console.WriteLine(rectangle.Area());
        Console.WriteLine(rectangle.Perimeter());


        Prism cube = new Prism(5, new Rectangle(5, 5));

        Console.WriteLine(cube.Volume());
        Console.WriteLine(cube.SurfaceArea());
        
        Prism cylinder = new Prism(5, new Circle(5));


    }
}