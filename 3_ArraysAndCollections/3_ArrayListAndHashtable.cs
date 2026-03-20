using System.Collections;
public class ArrayListAndHashtable
{
    public static void Run()
    {
        // ArrayList ve Hashtable; generic olmayan koleksiyonlardır (tür güvenliği daha zayıftır).
        // ArrayList
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Hello");
        arrayList.Add(3.14);
        Console.WriteLine("ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Hashtable
        Hashtable hashtable = new Hashtable();
        hashtable.Add("Name", "John");
        hashtable.Add("Age", 30);
        hashtable.Add("City", "New York");
        Console.WriteLine("\nHashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}   