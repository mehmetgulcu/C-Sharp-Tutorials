## 5_Nullable_Types.cs - Nullable Types (`?`)

Nullability; “değer var mı yok mu?” durumunu dil seviyesinde yönetmeyi sağlar. Bu dosya `int?` (nullable int) ile bunun nasıl yapıldığını gösterir.

### Kod Akışı

- Kullanıcıdan yaş istenir, `Console.ReadLine()` ile string alınır.
- `int.TryParse` ile string’in sayıya çevrilip çevrilemediği kontrol edilir.
- Geçerliyse `yas = result` yapılarak `int?` alanı dolar.
- Sonrasında:
  - `yas.HasValue` doğruysa `yas.Value` basılır,
  - değilse “yaş bilgisi girilmedi” mesajı verilir.

### Ne Öğrendim?

- `int? yas = null` ile nullable tanımlamak
- `TryParse` kullanarak güvenli parse etmek
- `HasValue` / `Value` ile değer okumak

