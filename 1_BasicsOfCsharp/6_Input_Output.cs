class InputOutput
{
    public static void Run()
    {
        Console.WriteLine("Basit Hesap Makinesi");

        Console.Write("Birinci sayıyı girin: ");
        string? input1 = Console.ReadLine();
        if (input1 == null)
        {
            Console.WriteLine("Geçersiz giriş!");
            return;
        }
        int number1 = int.Parse(input1);

        Console.Write("İkinci sayıyı girin: ");
        string? input2 = Console.ReadLine();
        if (input2 == null)
        {
            Console.WriteLine("Geçersiz giriş!");
            return;
        }
        int number2 = int.Parse(input2);

        int result = number1 + number2;
        Console.WriteLine($"Sonuç: {result}");
    }
}