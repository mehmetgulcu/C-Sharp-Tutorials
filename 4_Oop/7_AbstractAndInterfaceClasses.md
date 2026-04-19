# 7_AbstractAndInterfaceClasses.cs — Soyut sınıf ve arayüz

Bu dosya, **soyut sınıf (abstract class)** ile **arayüz (interface)** arasındaki rol farkını ödeme senaryosuyla gösterir.

## Konular

### Interface: `IIadeEdilebilir`

- Sadece imza içerir: `void IadeEt(decimal tutar);`
- “Bu yeteneği sunuyorum” **sözleşmesi**dir; bir sınıf birden fazla interface uygulayabilir.

### Abstract class: `OdemeYontemi`

- Ortak alan ve **somut** metot: `FisYazdir()` — tüm ödeme türleri paylaşır.
- **Soyut** metot: `OdemeYap()` — gövdesi yok; her alt sınıf **zorunlu** olarak doldurur.

### Somut sınıflar

- `KrediKarti : OdemeYontemi, IIadeEdilebilir` — hem soyut şablonu tamamlar hem iade yeteneğini ekler.
- `Nakit : OdemeYontemi` — sadece ödeme; `IadeEt` yoktur (ve çağrılamaz).

## Kodda yapılan işlemler

1. `KrediKarti` ile `OdemeYap`, `FisYazdir`, `IadeEt` kullanılır.
2. `Nakit` ile `OdemeYap` ve `FisYazdir` kullanılır; iade satırı bilinçli olarak yorumdadır.

## Karşılaştırma (kısa)

| Özellik        | Abstract class | Interface |
|----------------|----------------|-----------|
| Ortak kod      | Evet (`FisYazdir`) | C# 8+ varsayılan üyeler istisnası hariç tipik olarak hayır |
| Çoklu kalıtım  | Tek base class | Birden fazla interface |
| Amaç           | “İs-a” hiyerarşi şablonu | Yetenek / sözleşme |

---

*Not:* Gerçek bir ödeme sisteminde güvenlik, loglama ve idempotent işlemler eklenir; bu dosya OOP kavramlarını ayırt etmek içindir.
