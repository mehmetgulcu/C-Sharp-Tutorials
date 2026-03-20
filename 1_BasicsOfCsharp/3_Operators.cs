using System;

public class Operators
{
    public static void Run()
    {
        int a = 10;
        int b = 5;

        // Bu örnekte aynı değişkenler üzerinde farklı operatör türlerini deniyoruz.
        // Arithmetic Operators
        Console.WriteLine("Addition: " + (a + b)); // 15
        Console.WriteLine("Subtraction: " + (a - b)); // 5
        Console.WriteLine("Multiplication: " + (a * b)); // 50
        Console.WriteLine("Division: " + (a / b)); // 2
        Console.WriteLine("Modulus: " + (a % b)); // 0

        // Comparison Operators
        Console.WriteLine("Equal: " + (a == b)); // False
        Console.WriteLine("Not Equal: " + (a != b)); // True
        Console.WriteLine("Greater Than: " + (a > b)); // True
        Console.WriteLine("Less Than: " + (a < b)); // False

        // Logical Operators
        bool x = true;
        bool y = false;
        // && ve || şart birleştirmek için kullanılır; ! ise değeri tersler.
        Console.WriteLine("Logical AND: " + (x && y)); // False
        Console.WriteLine("Logical OR: " + (x || y)); // True
        Console.WriteLine("Logical NOT: " + (!x)); // False
    }
}