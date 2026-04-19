public class ClassAndStructRunner
{
    class SinifNokta { public int x; }
    struct StructNokta { public int x; }
    public static void Run()
    {
        SinifNokta s1 = new SinifNokta(); s1.x = 10;
        SinifNokta s2 = s1; // Adres kopyalandı
        s2.x = 20;
        Console.WriteLine(s1.x); // Çıktı: 20 (Çünkü ikisi de AYNI nesneye bakıyor)

        StructNokta st1 = new StructNokta(); st1.x = 10;
        StructNokta st2 = st1; // Değerler kopyalandı (YENİ bir kopya oluştu)
        st2.x = 20;
        Console.WriteLine(st1.x); // Çıktı: 10 (st1 bu değişimden ETKİLENMEDİ)

    }
}