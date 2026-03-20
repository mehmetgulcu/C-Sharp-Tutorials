class InputOutput
{
    public static void Run()
    {
        // Basit IO örneği: kullanıcıdan iki sayı alıp toplama yapar.
        Console.WriteLine("Basit Hesap Makinesi");

        Console.Write("Birinci sayıyı girin: ");
        // Console.ReadLine() string döndürür; null gelebilir (EOF vb.).
        string? input1 = Console.ReadLine();
        if (input1 == null)
        {
            Console.WriteLine("Geçersiz giriş!");
            return;
        }
        // int.Parse: giriş geçerli değilse exception fırlatabilir.
        int number1 = int.Parse(input1);

        Console.Write("İkinci sayıyı girin: ");
        string? input2 = Console.ReadLine();
        if (input2 == null)
        {
            Console.WriteLine("Geçersiz giriş!");
            return;
        }
        // İkinci sayıyı da int'e çevirip toplama yapıyoruz.
        int number2 = int.Parse(input2);

        int result = number1 + number2;
        Console.WriteLine($"Sonuç: {result}");
    }
}