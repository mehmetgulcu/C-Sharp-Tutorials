public class TryCatchFinallyThrow
{
    public static void Run()
    {
        Console.WriteLine("--- Try-Catch-Finally-Throw Örneği ---");

        try
        {
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 0)
            {
                // Kendi özel hatamızı fırlatıyoruz
                throw new ArgumentException("Negatif sayı giremezsiniz!");
            }

            Console.WriteLine($"Girdiğiniz sayı: {sayi}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Hata: Geçersiz format! Lütfen bir sayı giriniz.");
            Console.WriteLine($"Detay: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Try-catch bloğu tamamlandı.");
        }
    }
}