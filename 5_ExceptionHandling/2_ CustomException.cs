
// 1. Kendi Hata Sınıfımızı Tanımlıyoruz
public class YetersizBakiyeException : Exception
{
    public decimal MevcutBakiye { get; }

    // Mesajı ana Exception sınıfına 'base' ile gönderiyoruz
    public YetersizBakiyeException(string mesaj, decimal bakiye) : base(mesaj)
    {
        MevcutBakiye = bakiye;
    }
}

// 2. Hatanın Kullanımı
public class BankaHesabi
{
    public decimal Bakiye { get; private set; } = 500;

    public void ParaCek(decimal miktar)
    {
        if (miktar > Bakiye)
        {
            // Kendi hatamızı fırlatıyoruz (Throw)
            throw new YetersizBakiyeException("Hesabınızda yeterli bakiye yok!", Bakiye);
        }
        Bakiye -= miktar;
    }
}

// 3. ÇALIŞTIRICI (Try-Catch ile Yakalama)
public class CustomExceptionRunner
{
    public static void Run()
    {
        BankaHesabi hesap = new BankaHesabi();

        try
        {
            hesap.ParaCek(1000); // Hata fırlatacak
        }
        catch (YetersizBakiyeException ex)
        {
            // Kendi hatamıza özgü özelliklere (MevcutBakiye) erişebiliriz
            Console.WriteLine($"HATA: {ex.Message}");
            Console.WriteLine($"Senin bakiyen: {ex.MevcutBakiye} TL, ama sen daha fazla çekmek istedin.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Genel bir hata oluştu: " + ex.Message);
        }
    }
}
