public abstract class Animal
{
    public float Weight { get; set; }
    public string Color { get; set; }

    public Animal(string color, float weight)
    {
        Color = color;
        Weight = weight;
    }

    public abstract string MakeSound();
}

public abstract class AnimalWithTail : Animal
{
    public float TailLength { get; set; }

    public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
    {
        TailLength = tailLength;
    }
}

public class Cat : AnimalWithTail
{
    public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength) { }

    private string Purr()
    {
        return "purrrrrrrr";
    }

    private string Meow()
    {
        return "Meow";
    }

    public override string MakeSound()
    {
        return Purr() + " " + Meow();
    }

    public override string ToString()
    {
        return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
    }
}

public class Dog : AnimalWithTail
{
    public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength) { }

    public override string MakeSound()
    {
        return "Woof";
    }

    public override string ToString()
    {
        return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть колір кота: ");
        string catColor = Console.ReadLine();
        Console.Write("Введіть вагу кота: ");
        float catWeight = float.Parse(Console.ReadLine());
        Console.Write("Введіть довжину хвоста кота: ");
        float catTailLength = float.Parse(Console.ReadLine());
        Cat cat = new Cat(catColor, catWeight, catTailLength);

        Console.Write("Введіть колір собаки: ");
        string dogColor = Console.ReadLine();
        Console.Write("Введіть вагу собаки: ");
        float dogWeight = float.Parse(Console.ReadLine());
        Console.Write("Введіть довжину хвоста собаки: ");
        float dogTailLength = float.Parse(Console.ReadLine());
        Dog dog = new Dog(dogColor, dogWeight, dogTailLength);

        Console.WriteLine(cat.ToString());
        Console.WriteLine(cat.MakeSound());

        Console.WriteLine(dog.ToString());
        Console.WriteLine(dog.MakeSound());
    }
}