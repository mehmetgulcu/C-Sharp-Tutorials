public class ParametersAndReturn
{
    public static void Run()
    {
        Console.WriteLine("Toplama işlemi için iki sayı girin.");

        Console.Write("Birinci sayıyı girin: ");
        string? sum1 = Console.ReadLine();
        // Tutorial örneği: girişin geçerli bir tam sayıya dönüştürülebileceği varsayılır.
        int a = int.Parse(sum1);
        if (sum1 == null)
        {
            Console.WriteLine("Geçersiz giriş!");
            return;
        }

        Console.Write("İkinci sayıyı girin: ");
        string? sum2 = Console.ReadLine();
        // İkinci sayı da aynı şekilde int'e çevrilir.
        int b = int.Parse(sum2);
        if (sum2 == null)
        {
            Console.WriteLine("Geçersiz giriş!");
            return;
        }

        int result = GetSum(a, b);
        // Hesap sonucunu konsola yazdırıyoruz.
        Console.WriteLine("Toplam: " + result);
    }

    static int GetSum(int a, int b)
    {
        // Parametre olarak gelen sayıları toplar ve sonucu return eder.
        return a + b;
    }
}