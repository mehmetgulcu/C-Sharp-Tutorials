# 5_Inheritance.cs — Kalıtım (Inheritance)

Bu dosya, bir sınıfın başka bir sınıfın üyelerini **miras almasını** (`:` ile) gösterir: **üst sınıf (base)** ve **alt sınıf (derived)**.

## Konular

### Base sınıf: `Hayvan`

- `Ad` alanı ve `YemekYe()` metodu tüm hayvanlar için ortak davranışı temsil eder.

### Derived sınıf: `Kopek : Hayvan`

- `Hayvan`’daki her şey `Kopek`’e gelir (erişim belirleyicilerine bağlı olarak).
- Ek olarak `Havla()` ile köpeğe özel davranış eklenir.

## Kodda yapılan işlemler

1. `Kopek k = new Kopek()` ile alt sınıf örneği oluşturulur.
2. `k.Ad` üst sınıftan gelen alana yazılır.
3. `k.YemekYe()` üst sınıf metodudur; köpek nesnesi üzerinden çağrılır.
4. `k.Havla()` alt sınıfa özgü metoddur.

## Özet

| Kavram        | Bu örnekte |
|---------------|------------|
| Kalıtım       | `Kopek : Hayvan` |
| Kod yeniden kullanımı | Ortak mantık `Hayvan`’da |
| Genişletme    | `Kopek`’e `Havla()` |

---

*Not:* Alanların yine `public` olması öğretim kolaylığı içindir; gerçek projede property ve uygun erişim seviyesi tercih edilir.
