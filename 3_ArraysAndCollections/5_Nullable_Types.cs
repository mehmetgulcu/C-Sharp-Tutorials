public class NullableTypes
{
    public static void Run()
    {
        Console.Write("Yaşınızı girin (Boş bırakabilirsiniz): ");
        string? input = Console.ReadLine();

        // int.Parse yerine TryParse kullanarak null ve format hatalarını engelleyelim
        int? yas = null;
        if (int.TryParse(input, out int result))
        {
            yas = result;
        }

        // ARTIK HASVALUE VE VALUE ÇALIŞIR
        if (yas.HasValue)
        {
            Console.WriteLine("Girdiğiniz yaş: " + yas.Value);
        }
        else
        {
            Console.WriteLine("Yaş bilgisi girilmedi.");
        }
    }
}