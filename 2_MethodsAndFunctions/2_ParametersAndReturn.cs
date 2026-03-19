public class ParametersAndReturn
{
    public static void Run()
    {
        Console.WriteLine("Toplama işlemi için iki sayı girin.");

        Console.Write("Birinci sayıyı girin: ");
        string? sum1 = Console.ReadLine();
        int a = int.Parse(sum1);
        if (sum1 == null)
        {
            Console.WriteLine("Geçersiz giriş!");
            return;
        }

        Console.Write("İkinci sayıyı girin: ");
        string? sum2 = Console.ReadLine();
        int b = int.Parse(sum2);
        if (sum2 == null)
        {
            Console.WriteLine("Geçersiz giriş!");
            return;
        }

        int result = GetSum(a, b);
        Console.WriteLine("Toplam: " + result);
    }

    static int GetSum(int a, int b)
    {
        return a + b;
    }
}