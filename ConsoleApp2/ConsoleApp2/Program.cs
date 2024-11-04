class Fruit
{
    public string Name { get; set; }

    public Fruit(string name)
    {
        Name = name;
    }
}

class Apple : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }

    public Apple(string name, string variety, string color) : base(name)
    {
        Variety = variety;
        Color = color;
    }
}

class Pear : Fruit
{
    public string Color { get; set; }

    public Pear(string name, string color) : base(name)
    {
        Color = color;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Apple apple = new Apple("Apple", "Granny Smith", "Green");
        Pear pear = new Pear("Pear", "Yellow");

        Console.WriteLine($"Fruit: {apple.Name}, Variety: {apple.Variety}, Color: {apple.Color}");
        Console.WriteLine($"Fruit: {pear.Name}, Color: {pear.Color}");
    }
}