class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dotnet Console uygulaması çalışıyor.");
        // Bu projede diziler/koleksiyonlar konuları farklı Run() metotlarıyla ayrılmış.
        // Çalıştırmak istediğini Program.cs içinden uncomment ederek seçebilirsin.

        // Arrays.Run();
        // GenericCollection.Run();
        // ArrayListAndHashtable.Run();
        // Tuples.Run();
        // NullableTypes.Run();
        // Indexers.Run();
        SpanAndMemory.Run();
    }
}