class Personel
{
    // 1. GİZLEME: Alanı 'private' yaparak dışarıdan direkt erişimi (personel.maas = -5) engelledik.
    private double _maas;

    // 2. KONTROLLÜ ERİŞİM: Property (Özellik) üzerinden okuma ve yazma kuralları koyduk.
    public double Maas
    {
        get 
        { 
            return _maas; // Değeri güvenle dışarı veriyoruz.
        }
        set 
        { 
            // Mantıksal denetim: Maaş 17.002 TL'den az girilemez!
            if (value >= 17002) 
                _maas = value; 
            else 
                Console.WriteLine("Hata: Asgari ücretin altında maaş girilemez.");
        }
    }
}

public class Encapsulation
{
    public static void Run()
    {
        // KULLANIM:
        Personel p = new Personel();

        p.Maas = 25000;      // 'set' bloğu çalışır, veri atanır.
        p.Maas = 23000;       // 'set' bloğu çalışır, HATA mesajı verir, veri değişmez.

        Console.WriteLine(p.Maas); // 'get' bloğu çalışır, mevcut maaşı döner.
    }
}