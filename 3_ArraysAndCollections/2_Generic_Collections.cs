using System.Diagnostics;

public class GenericCollection
{
    public static void Run()
    {
        // Bu örnekte generic koleksiyonlar kullanılıyor: tür bilgisi koleksiyonun kendisine bağlı.
        // 1. List<T> (Dinamik Liste)
        List<string> names = new List<string>();
        names.Add("Mehmet");
        names.Add("Ahmet");
        names.Add("Ayşe");

        Console.WriteLine("Names List:");
        foreach (var name in names)
        {
            Console.WriteLine(name);

            if (name == "Ahmet")
            {
                Console.WriteLine("Ahmet bulundu!");
                // Dikkat: Eğitim amaçlıdır. Listeyi foreach sırasında değiştirmek hata senaryolarına yol açabilir.
                names.Remove(name); // Ahmet'i listeden kaldır
                Console.WriteLine("Ahmet listeden kaldırıldı.");
                break; // Döngüyü kırarak devam et
            }
        }

        // 2. Dictionary<TKey, TValue> (Sözlük)
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages["Mehmet"] = 30;
        ages["Ahmet"] = 25;
        ages["Ayşe"] = 28;

        Console.WriteLine("\nAges Dictionary:");
        foreach (var kvp in ages)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} yaşında");
        }

        // 3. Queue<T> (Kuyruk - FIFO)
        Queue<string> bankaSirasi = new Queue<string>();
        bankaSirasi.Enqueue("Ali");    // Sıraya ilk girdi
        bankaSirasi.Enqueue("Veli");   // Sıraya ikinci girdi

        // İşlemi biteni sıradan çıkar (İlk giren ilk çıkar)
        string islemGoren = bankaSirasi.Dequeue();
        Console.WriteLine($"İşlem Gören: {islemGoren}"); // Çıktı: Ali

        // 4. Stack<T> (Yığın - LIFO)
        Stack<string> kitapYigini = new Stack<string>();
        kitapYigini.Push("Kitap 1"); // Yığına ilk kitap kon
        kitapYigini.Push("Kitap 2"); // Yığına ikinci kitap kon
        kitapYigini.Push("Kitap 3"); // Yığına üçüncü kitap kon

        // En üstteki kitabı çıkar (Son giren ilk çıkar)
        string enUstKitap = kitapYigini.Pop();
        Console.WriteLine($"En Üst Kitap: {enUstKitap}"); // Çıktı: Kitap 3
    }
}