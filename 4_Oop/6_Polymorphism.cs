using System;

namespace PolymorphismExample
{
    // ÜST SINIF
    public class Hayvan
    {
        // virtual: Alt sınıflar bu metodu override edebilir (ezebilir)
        public virtual void SesCikar()
        {
            Console.WriteLine("Hayvan ses çıkarıyor...");
        }
    }

    // ALT SINIF 1
    public class Kedi : Hayvan
    {
        // override: Üst sınıftaki metodu kediye özel hale getiriyoruz
        public override void SesCikar()
        {
            Console.WriteLine("Miyav!");
        }
    }

    // ALT SINIF 2
    public class Kopek : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Hav hav!");
        }
    }

    // ÇALIŞTIRICI SINIF
    public class PolymorphismRunner
    {
        public static void Run()
        {
            Console.WriteLine("--- Polymorphism Örneği ---");

            Hayvan h1 = new Kedi();
            Hayvan h2 = new Kopek();
            Hayvan h3 = new Hayvan();

            h1.SesCikar(); // Çıktı: Miyav!
            h2.SesCikar(); // Çıktı: Hav hav!
            h3.SesCikar(); // Çıktı: Hayvan ses çıkarıyor...
        }
    }
}
