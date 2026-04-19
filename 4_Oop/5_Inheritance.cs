// ÜST SINIF (Base Class / Parent)
class Hayvan
{
    public string Ad;
    public void YemekYe()
    {
        Console.WriteLine(Ad + " yemek yiyor.");
    }
}

// ALT SINIF (Derived Class / Child)
// 'Hayvan' sınıfındaki her şeyi miras alır.
class Kopek : Hayvan 
{
    public void Havla()
    {
        Console.WriteLine("Hav hav!");
    }
}

public class Inheritance
{
    public static void Run()
    {
        Kopek k = new Kopek();
        k.Ad = "Karabas";
        k.YemekYe();
        k.Havla();
    }
}