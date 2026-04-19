# 4_Encapsulation.cs — Kapsülleme (Encapsulation)

Bu dosya, OOP’nin temel ilkelerinden **kapsüllemeyi** property ve private alan ile somutlaştırır: veriyi gizle, erişimi kurallara bağla.

## Konular

### Veriyi gizleme

- `_maas` alanı `private` olduğu için `p._maas = ...` gibi doğrudan atama dışarıdan yapılamaz.

### Kontrollü erişim (property)

- `Maas` property’sinin `get` bloğu değeri okur.
- `set` bloğu yazılan değeri **doğrular**: örnekte asgari ücretin altındaki değerler reddedilir ve uyarı yazılır.

## Kodda yapılan işlemler

1. `Personel` nesnesi oluşturulur.
2. `p.Maas = 25000` koşulu sağlar (`>= 17002`), `_maas` güncellenir.
3. `p.Maas = 23000` de koşulu sağlar; `_maas` **23000** olur (dosyadaki bazı yorumlarla karıştırmayın — hata için örneğin `15000` gibi eşik altı bir değer kullanılmalıdır).
4. `Console.WriteLine(p.Maas)` ile güncel maaş okunur (çıktı **23000**).

## Özet

| İlke              | Bu örnekte |
|-------------------|------------|
| Gizleme           | `_maas` private |
| Doğrulama         | `set` içinde `value` kontrolü |
| Dış API           | Tek giriş: `Maas` property |

---

*İpucu:* Doğrulama kurallarını ileride ayrı bir metoda veya value object’e taşımak büyük projelerde yaygındır; bu dosya temel pattern’i net gösterir.
