## 2_ParametersAndReturn.cs - Parametre ve Return

Bu dosya, “metot dışarıdan nasıl bilgi alır ve sonucu nasıl geri döndürür?” sorusuna cevap gibi.

### Kod Akışı

- Kullanıcıdan iki sayı istenir.
- Kullanıcı girişleri `Console.ReadLine()` ile okunur.
- `GetSum(int a, int b)` metodu iki sayıyı alır ve toplamı hesaplayıp `return` eder.

### Blog Notu

`return` sadece değer döndürmez; metodu “bitti” noktası gibi düşünmenizi sağlar. Böylece `Run()` içinde hesaplama mantığını metot taşıdığı için `Run()` daha temiz olur.

### Ne Öğrendim?

- Metot parametreleri (`int a, int b`)
- Metottan değer döndürme (`return a + b`)

