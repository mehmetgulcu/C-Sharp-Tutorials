## 6_Input_Output.cs - Konsol Girişi ve Çıkışı

Blog gibi anlatırsak: C# ile “gerçek kullanıcı etkileşimi” genelde önce konsolda başlar. Bu dosya, iki sayı alıp toplamını hesaplayan basit bir örnek içerir.

### Kod Akışı

- `Console.Write` ile kullanıcıdan giriş istenir.
- `Console.ReadLine()` ile string olarak değer alınır.
- `null` gelirse program güvenli şekilde `return` ile durur.
- Sonra `int.Parse(...)` ile sayıya çevrilir.
- Son olarak `number1 + number2` hesaplanıp ekrana yazdırılır.

### Kritik Nokta

`int.Parse` giriş geçersiz olduğunda exception fırlatabilir. Bu eğitim örneği “doğru giriş” varsayar.

### Ne Öğrendim?

- `Console.ReadLine()` ile veri okuma
- `null` kontrolü ile erken çıkış
- `int.Parse` ile string -> int dönüşümü

