public class Arrays
{
    public static void Run()
    {
        // Bu örnek; tek boyutlu, çok boyutlu ve jagged array türlerini gösterir.
        // 1. Tek Boyutlu Diziler (Single-Dimensional Arrays)

        // Array tanımlama ve kullanma
        int[] numbers = new int[5]; // 5 elemanlı bir dizi oluşturur
        numbers[0] = 10; // Dizinin ilk elemanına değer atama
        numbers[1] = 20; // Dizinin ikinci elemanına değer atama

        Console.WriteLine("Dizinin ilk elemanı: " + numbers[0]);
        Console.WriteLine("Dizinin ikinci elemanı: " + numbers[1]);

        // Dizi uzunluğunu alma
        Console.WriteLine("Dizinin uzunluğu: " + numbers.Length);

        // 2. Çok Boyutlu Diziler (Multidimensional Arrays)

        int [,] matrix = new int[2, 3]; // 2 satır ve 3 sütunlu bir matris oluşturur
        matrix[0, 0] = 1; // İlk satır, ilk sütun
        matrix[0, 1] = 2; // İlk satır, ikinci sütun
        matrix[0, 2] = 3; // İlk satır, üçüncü sütun
        matrix[1, 0] = 4; // İkinci satır, ilk sütun
        matrix[1, 1] = 5;   // İkinci satır, ikinci sütun
        matrix[1, 2] = 6;   // İkinci satır, üçüncü sütun 

        Console.WriteLine("Matrisin ilk satır, ilk sütun elemanı: " + matrix[0, 0]);
        Console.WriteLine("Matrisin ikinci satır, üçüncü sütun elemanı: " + matrix[1, 2]);

        // 3. Jagged Arrays (Çok Boyutlu Diziler)
        int[][] jaggedArray = new int[3][]; // 3 satırdan oluşan bir jagged array oluşturur
        jaggedArray[0] = new int[] { 1, 2 }; // İlk satır 2 elemanlı
        jaggedArray[1] = new int[] { 3, 4, 5 }; // İkinci satır 3 elemanlı
        jaggedArray[2] = new int[] { 6 }; // Üçüncü satır 1 elemanlı

        Console.WriteLine("Jagged array'in ilk satır, ikinci elemanı: " + jaggedArray[0][1]);
        Console.WriteLine("Jagged array'in ikinci satır, üçüncü elemanı: " + jaggedArray[1][2]);
        Console.WriteLine("Jagged array'in üçüncü satır, ilk elemanı: " + jaggedArray[2][0]);
    }
}