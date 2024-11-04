public abstract class Фігура
{
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

public class Коло : Фігура
{
    public double Radius { get; set; }

    public Коло(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}