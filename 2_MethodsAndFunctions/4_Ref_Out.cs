public class RefOut
{
    public static void Run()
    {
        int number1 = 5;
        int number2 = 10;

        // `ref`: Değeri metot içinde değiştirmek ve çağırana geri yansıtmak için kullanılır.
        Console.WriteLine("Ref kullanarak iki sayıyı değiştirme:");
        Console.WriteLine($"Başlangıçta: number1 = {number1}, number2 = {number2}");
        Swap(ref number1, ref number2);
        Console.WriteLine($"Sonra: number1 = {number1}, number2 = {number2}");

        // `out`: Metot, parametreyi çağırmadan önce kesin olarak atayacağını garanti eder.
        Console.WriteLine("\nOut kullanarak bir sayıyı hesaplama:");
        int result;
        CalculateSquare(4, out result);
        Console.WriteLine($"4'ün karesi: {result}");
    }

    static void Swap(ref int a, ref int b)
    {
        // İki değerin yerini değiştiriyoruz.
        int temp = a;
        a = b;
        b = temp;
    }

    static void CalculateSquare(int number, out int square)
    {
        // Metot, out parametresine hesapladığı değeri yazar.
        square = number * number;
    }
}