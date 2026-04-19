class Car
{
    public string Brand;
    public string Color;
    public int Price;

    public void Info()
    {
        Console.WriteLine($"{Brand} is driving.");
        Console.WriteLine($"Car is {Color}.");
        Console.WriteLine($"Car {Price} dollar.");
    }
}

public class ClassAndObject
{
    public static void Run()
    {
        Car car1 = new Car();
        car1.Brand = "BMW";
        car1.Color = "Red";
        car1.Price = 50000;

        car1.Info();
    }
}