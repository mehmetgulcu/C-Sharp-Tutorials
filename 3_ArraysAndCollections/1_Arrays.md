## 1_Arrays.cs - Diziler (Arrays)

Diziler, aynı tipte birden fazla değeri tek bir değişkende saklamanın yoludur. Bu dosya hem tek boyutlu, hem çok boyutlu hem de “jagged array” örnekleri gösterir.

### Kodda Olanlar

- `int[] numbers = new int[5]` ile 5 elemanlık tek boyutlu dizi.
- `int[,] matrix = new int[2, 3]` ile 2 satır x 3 sütun çok boyutlu dizi (matris).
- `int[][] jaggedArray = new int[3][]` ile satırları farklı uzunlukta olabilen jagged array.

### Ne Öğrendim?

- Dizilerde değer atama: `numbers[index] = ...`
- Dizi uzunluğu: `numbers.Length`
- Çok boyutlu erişim: `matrix[satir, sutun]`
- Jagged erişim: `jaggedArray[satir][sutun]`

