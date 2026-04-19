
// 1. INTERFACE: Bir yetenek kazandırır (Sözleşme)
public interface IIadeEdilebilir
{
    void IadeEt(decimal tutar);
}

// 2. ABSTRACT CLASS: Bir temel şablon oluşturur (Kalıtım için)
public abstract class OdemeYontemi
{
    public decimal Tutar { get; set; }

    // Ortak metot (Gövdesi var)
    public void FisYazdir()
    {
        Console.WriteLine($"{Tutar} TL tutarındaki işlem kaydedildi.");
    }

    // Soyut metot (Gövdesi yok, alt sınıflar doldurmak ZORUNDA)
    public abstract void OdemeYap();
}

// 3. SOMUT SINIF 1: Kredi Kartı (Hem ödeme yapar hem iade edebilir)
public class KrediKarti : OdemeYontemi, IIadeEdilebilir
{
    public override void OdemeYap()
    {
        Console.WriteLine("Kredi kartı ile güvenli ödeme yapıldı.");
    }

    public void IadeEt(decimal tutar)
    {
        Console.WriteLine($"{tutar} TL kredi kartına iade edildi.");
    }
}

// 4. SOMUT SINIF 2: Nakit (Sadece ödeme yapar, iade yeteneği yok)
public class Nakit : OdemeYontemi
{
    public override void OdemeYap()
    {
        Console.WriteLine("Ödeme nakit olarak kasaya alındı.");
    }
}

// ÇALIŞTIRICI
public class AbstractAndInterfaceClasses
{
    public static void Run()
    {
        Console.WriteLine("--- Ödeme Sistemi ---");

        KrediKarti kk = new KrediKarti { Tutar = 500 };
        kk.OdemeYap();   // Abstract'tan gelen zorunlu metot
        kk.FisYazdir();  // Abstract'tan gelen hazır metot
        kk.IadeEt(500);  // Interface'den gelen yetenek

        Console.WriteLine("------------------");

        Nakit n = new Nakit { Tutar = 100 };
        n.OdemeYap();
        n.FisYazdir();
        // n.IadeEt(); // HATA! Nakit sınıfı iade yeteneğine sahip değildir.
    }
}
