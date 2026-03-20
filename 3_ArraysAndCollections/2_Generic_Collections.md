## 2_Generic_Collections.cs - Generic Collection’lar

Bu dosya, C#’ta en sık kullanılan generic koleksiyonları tanıtmak için yazılmış: `List`, `Dictionary`, `Queue` ve `Stack`.

### Kod Akışı

- `List<string>`: Eklemeye uygun dinamik liste.
- `Dictionary<string, int>`: Anahtar-değer (key-value) sözlüğü.
- `Queue<string>`: FIFO (ilk giren ilk çıkar).
- `Stack<string>`: LIFO (son giren ilk çıkar).

### Ne Öğrendim?

- Her collection’ın davranış farkı vardır (FIFO/LIFO).
- `foreach` ile koleksiyonları dolaşabilirsiniz.

### Dikkat

Örnekte `names.Remove(name)` çağrısı `foreach` içinde yapılıyor. Gerçek hayatta koleksiyon üzerinde aynı anda değişiklik yapmak hataya yol açabilir; burada eğitim amaçlı basitleştirilmiş bir akış var.

