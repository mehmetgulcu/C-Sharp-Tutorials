public class OptionalParameters
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

        Console.Write("İkinci sayıyı girin (isteğe bağlı, varsayılan 0): ");
        string? sum2 = Console.ReadLine();
        // Kullanıcı ikinci sayıyı girmezse b = 0 olarak devam edilir.
        int b = 0; // Varsayılan değer
        if (!string.IsNullOrEmpty(sum2))
        {
            b = int.Parse(sum2);
        }

        int result = GetSum(a, b);
        Console.WriteLine("Toplam: " + result);
    }

    static int GetSum(int a, int b = 0)
    {
        // İsteğe bağlı parametre: b verilmezse otomatik olarak 0 olur.
        return a + b;
    }
}