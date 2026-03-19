public class LocalFunctions
{
    public static void Run()
    {
        Console.WriteLine("Local Functions örneği:");
        
        int carpimKatsayisi = 2;

        int Calculate(int a, int b)
        {
            return (a + b) * carpimKatsayisi;
        }

        int result = Calculate(5, 10);
        Console.WriteLine($"Sonuç: {result}");
    }
}