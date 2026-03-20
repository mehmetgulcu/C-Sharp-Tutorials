## 7_SpanAndMemory.cs - `Span<T>`

`Span<T>`; bellek üzerinde “dilim (slice)” mantığıyla çalışan, ek tahsis (allocation) yapmadan bir parçayı temsil edebilen yapıdır.

### Kod Akışı

- `int[] sayilar = { 10, 20, 30, 40, 50 };` ile dizi oluşturulur.
- `sayilar.AsSpan(1, 3)` ile 1. indisten başlayarak 3 elemanlık bir `Span<int>` elde edilir.
- `dilim[0] = 99;` ile dilim üzerinden değiştirilen değer, orijinal dizide de görünür.
- Son olarak `string.Join` ile dizi içeriği yazdırılır.

### Ne Öğrendim?

- `AsSpan(start, length)` ile slice alma
- `Span` üzerinden değiştirmenin orijinal veriyi etkilemesi

