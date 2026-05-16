namespace Interfaces.Validation;

public class TriangleValidation
{
    public static void  Validate(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Triangle sides must be positive");
        }
        
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("Invalid triangle sides");
    }
}