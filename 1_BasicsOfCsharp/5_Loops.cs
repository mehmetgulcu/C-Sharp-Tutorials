class Loops
{
    public static void Run()
    {

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"For Döngüsü: {i}");
        }

        for (int j = 5; j > 0; j--)
        {
            Console.WriteLine($"Ters For Döngüsü: {j}");
        }

        int k = 0;
        do
        {
            Console.WriteLine($"Do-While Döngüsü: {k}");
            k++;
        }
        while (k < 5);

        int l = 0;
        while (l < 5)
        {
            Console.WriteLine($"While Döngüsü: {l}");
            l++;
        }
    }
}