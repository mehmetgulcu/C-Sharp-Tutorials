public class LocalFunctions
{
    public static void Run()
    {
        Console.WriteLine("Local Functions örneği:");
        
        // Local function sadece bu metot içinde kullanılacak şekilde yardımcı hesap yapar.
        int carpimKatsayisi = 2;

        int Calculate(int a, int b)
        {
            // Local function dışarıdaki carpimKatsayisi değerini de kullanır.
            return (a + b) * carpimKatsayisi;
        }

        int result = Calculate(5, 10);
        Console.WriteLine($"Sonuç: {result}");
    }
}