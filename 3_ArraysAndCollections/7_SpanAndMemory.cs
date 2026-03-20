public class SpanAndMemory
{
    public static void Run()
    {
        // Span, dizinin bir bölümünü temsil eder; yeni dizi tahsis etmek zorunda değildir.
        int[] sayilar = { 10, 20, 30, 40, 50 };
        Span<int> dilim = sayilar.AsSpan(1, 3); // { 20, 30, 40 } kısmına bakar
        // Dilim üzerinden güncelleme orijinal diziyi de etkiler.
        dilim[0] = 99; // Orijinal dizideki 20, 99 olur!
        Console.WriteLine(string.Join(", ", sayilar)); // Çıktı: 10, 99, 30, 40, 50
    }
}