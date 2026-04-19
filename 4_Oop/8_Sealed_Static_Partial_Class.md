# 8_Sealed_Static_Partial_Class.cs — Sealed, static ve partial sınıflar

Bu dosya, üç farklı sınıf niteliğini tek örnekte toplar: **static**, **partial**, **sealed**.

## Konular

### Static class (`LogHelper`)

- Örnek oluşturulmaz: `new LogHelper()` yoktur.
- Üyeler genelde `static` olur; `LogHelper.BilgiYaz(...)` ile doğrudan sınıf adından çağrılır.
- Yardımcı / yardımcı araç (utility) kalıpları için uygundur.

### Partial class (`Kullanici`)

- Aynı sınıf adı iki kez tanımlanır; derleyici bunları **tek sınıf** gibi birleştirir.
- Büyük sınıfları dosyalara bölmek veya tasarımcı üretimi kodla birleştirmek için kullanılır.

### Sealed class (`SistemAyarlari`)

- Bu sınıftan **kalıtım yapılamaz**: `class X : SistemAyarlari` yazılamaz.
- Tasarımı kilitlemek veya güvenlik / tutarlılık için mirası bilinçli olarak kapatmak için kullanılır.

## Kodda yapılan işlemler

1. `LogHelper.BilgiYaz` ile statik çağrı.
2. `Kullanici` nesnesi oluşturulur; property bir parçada, `Selamla` diğer parçada olsa da tek nesne gibi kullanılır ve içeride yine `LogHelper` kullanılır.
3. `SistemAyarlari` örneği oluşturulup `AyarlariGoster` çağrılır.

## Özet

| Anahtar kelime | Bu örnekteki rol |
|----------------|------------------|
| `static`       | Nesnesiz yardımcı log |
| `partial`      | Aynı sınıfı iki blokta tanımlama |
| `sealed`       | Mirası kapatma |

---

*İpucu:* `static` sınıfa çok fazla görev yüklemeden modüler tasarım için genelde normal sınıf + DI (dependency injection) tercih edilir; küçük konsol örnekleri için static uygundur.
