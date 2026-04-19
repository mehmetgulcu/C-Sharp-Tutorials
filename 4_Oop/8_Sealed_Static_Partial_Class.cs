
// 1. STATIC CLASS: Uygulama genelinde nesne oluşturmadan kullanılan yardımcı araçlar.
public static class LogHelper
{
    public static void BilgiYaz(string mesaj)
        => Console.WriteLine($"[LOG - {DateTime.Now.ToShortTimeString()}]: {mesaj}");
}

// 2. PARTIAL CLASS (Bölüm 1): Sınıfın kimlik bilgilerini burada tutuyoruz.
public partial class Kullanici
{
    public string Ad { get; set; } = string.Empty;
}

// 2. PARTIAL CLASS (Bölüm 2): Aynı sınıfın metotlarını farklı bir yerdeymiş gibi tanımlıyoruz.
public partial class Kullanici
{
    public void Selamla() => LogHelper.BilgiYaz($"Merhaba, {Ad}");
}

// 3. SEALED CLASS: Güvenlik nedeniyle bu sınıftan başka sınıf türetilmesini engelliyoruz.
public sealed class SistemAyarlari
{
    public string Versiyon { get; } = "v1.0.4";
    public void AyarlariGoster() => Console.WriteLine($"Sistem Versiyonu: {Versiyon}");
}

// ÇALIŞTIRICI
public class SealedStaticPartialClassRunner
{
    public static void Run()
    {
        // Static kullanımı: Direkt sınıf adıyla erişilir.
        LogHelper.BilgiYaz("Uygulama başlatıldı.");

        // Partial kullanımı: Farklı dosyalarda/parçalarda olsa da tek nesne gibi davranır.
        Kullanici k = new Kullanici { Ad = "Mehmet" };
        k.Selamla();

        // Sealed kullanımı: Nesne oluşturulur ama miras verilemez.
        SistemAyarlari ayar = new SistemAyarlari();
        ayar.AyarlariGoster();
    }
}