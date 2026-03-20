public class Tuples
{
    public static void Run()
    {
        // Tuple: birden fazla değeri tek bir nesne altında taşımak için kullanılır.
        // Tuple creation
        var person = Tuple.Create("John", 30, "New York");
        Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}, City: {person.Item3}");

        // Deconstructing a tuple
        // Deconstruct ile tuple değerlerini ayrı değişkenlere ayırabiliriz.
        var (name, age, city) = person;
        Console.WriteLine($"Deconstructed - Name: {name}, Age: {age}, City: {city}");
    }
}