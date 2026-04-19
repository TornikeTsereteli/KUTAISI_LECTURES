namespace Week_7_1_OOP_Exercises_2.Task1;

public class ThermometerLog
{
    private string location;
    private double[] readings;
    private char unit;

    public ThermometerLog(string location, double[] readings, char unit)
    {
        if(unit != 'C' && unit != 'F') throw new ArgumentException("Unit must be either C or F");
        this.location = location;
        this.readings = readings;
        this.unit = unit;
    }
    
    public string GetLocation() => location;
    public double[] GetReadings() => readings;
    public char GetUnit() => unit;
    
    
    public double GetAverage() => readings.Average();
    public double GetMin() => readings.Min();
    public double GetMax() => readings.Max();
    
    public void ConvertToCelsius()
    {
        if(unit == 'C') return;

        for (int i = 0; i < readings.Length; i++)
        {
            readings[i] = (readings[i] - 32) * 5 / 9;
        }
        unit = 'C';
    }

    public void ConvertToFahrenheit()
    {
        if(unit == 'F') return;
        
        for (int i = 0; i < readings.Length; i++)
        {
            readings[i] = (readings[i] * 9 / 5) + 32;
        }
        unit = 'F';
    }

    public bool HasFever()
    {
        if (unit == 'F')
        {
            return readings.Select(t => (t - 32) * 5 / 9).Any(t => t >= 37.5);
        }
        return readings.Any(t => t >= 37.5);
    }
    
    
    public override string ToString() => $"{location} {string.Join(" ", readings)} {unit}";
    
}