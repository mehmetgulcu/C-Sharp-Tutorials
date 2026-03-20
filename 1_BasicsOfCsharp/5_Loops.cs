class Loops
{
    public static void Run()
    {

        // for: kaç tur döneceğini (i < 5) şartıyla belirler.
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"For Döngüsü: {i}");
        }

        // Ters for: aynı mantığı geriye doğru uygular.
        for (int j = 5; j > 0; j--)
        {
            Console.WriteLine($"Ters For Döngüsü: {j}");
        }

        int k = 0;
        // do-while: koşul yanlış olsa bile en az 1 kez çalışır.
        do
        {
            Console.WriteLine($"Do-While Döngüsü: {k}");
            k++;
        }
        while (k < 5);

        int l = 0;
        // while: koşul doğru kaldığı sürece döner.
        while (l < 5)
        {
            Console.WriteLine($"While Döngüsü: {l}");
            l++;
        }
    }
}