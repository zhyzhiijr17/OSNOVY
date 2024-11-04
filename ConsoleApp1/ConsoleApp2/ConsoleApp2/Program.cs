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

public class Прямокутник : Фігура
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Прямокутник(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта класу Коло
        Коло коло = new Коло(5);
        Console.WriteLine($"Коло: Площа = {коло.CalculateArea():F2}, Периметр = {коло.CalculatePerimeter():F2}");

        // Створення об'єкта класу Прямокутник
        Прямокутник прямокутник = new Прямокутник(4, 6);
        Console.WriteLine($"Прямокутник: Площа = {прямокутник.CalculateArea():F2}, Периметр = {прямокутник.CalculatePerimeter():F2}");
    }
}