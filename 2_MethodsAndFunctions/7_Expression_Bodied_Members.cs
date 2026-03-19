public class ExpressionBodiedMembers
{
    public static void Run()
    {
        Console.WriteLine("Expression Bodied Members örneği:");
        Console.WriteLine($"Toplama sonucu: {Add(5, 10)}");
    }

    // Expression-bodied method
    public static int Add(int a, int b) => a + b;
}