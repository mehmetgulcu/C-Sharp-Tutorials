# 3_Access_Modifiers.cs — Erişim belirleyicileri

Bu dosya, sınıf üyelerinin **kimin görebileceğini ve değiştirebileceğini** kontrol eden **erişim belirleyicilerini (access modifiers)** özetler.

## Konular

| Belirleyici           | Anlamı (kısa) |
|-----------------------|----------------|
| `public`              | Her yerden erişim |
| `private`             | Sadece tanımlandığı sınıf içi |
| `protected`           | Sınıf + türeyen alt sınıflar |
| `internal`            | Aynı assembly (proje) içi |
| `protected internal`  | Aynı assembly **veya** başka assembly’de türeyen sınıflar |

## Kodda yapılan işlemler

1. `Person` içinde farklı erişim seviyelerinde property’ler tanımlanır.
2. `AccessModifiers.Run()` içinde **aynı assembly** ve **sınıf dışı** bir yerden hangi üyelere erişilebildiği gösterilir:
   - `Name`, `PhoneNumber`, `Email` atanabilir ve yazdırılır.
   - `Age` ve `Address` için doğrudan erişim kod içinde yorumla engellenmiştir — derleyici hatası vereceği için kullanılmaz.

## Neden önemli?

- **Kapsülleme:** Dış dünyaya sadece güvenli yüzey alanını açarsınız.
- **Bakım:** İç detayları değiştirirken dış API’yi koruyabilirsiniz.

---

*Not:* `protected` ve `protected internal` davranışını tam görmek için `Person`’dan türeyen bir alt sınıf örneği de eklenebilir; bu dosya ana fikri `Run()` ile gösteriyor.
