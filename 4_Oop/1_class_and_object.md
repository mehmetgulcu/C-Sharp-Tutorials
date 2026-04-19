# 1_class_and_object.cs — Sınıf ve nesne

Bu dosya, nesne yönelimli programlamanın temel taşları olan **sınıf (class)** ve **nesne (object / instance)** kavramlarını gösterir.

## Konular

### Sınıf (`Car`)

- **Alanlar (fields):** `Brand`, `Color`, `Price` — bir arabanın durumunu tutar.
- **Davranış:** `Info()` metodu — bu verileri konsola yazdırır.

Sınıf, bir şablon veya kalıptır; tek başına bellekte “somut” bir araba oluşturmaz.

### Nesne (`car1`)

- `new Car()` ile sınıftan **örnek (instance)** üretilir.
- `car1.Brand = "BMW"` gibi atamalarla nesnenin özellikleri doldurulur.
- `car1.Info()` ile o nesnenin davranışı çağrılır.

## Kodda yapılan işlemler

1. `Car` sınıfı tanımlanır.
2. `ClassAndObject.Run()` içinde `Car` tipinde `car1` nesnesi oluşturulur.
3. Alanlara değer atanır.
4. `Info()` çağrılarak çıktı üretilir.

## Özet

| Kavram   | Bu örnekte |
|----------|------------|
| Sınıf    | `Car` — şablon |
| Nesne    | `car1` — bellekteki örnek |
| Üye      | Alanlar + `Info()` metodu |

---

*Not:* Alanların `public` olması hızlı öğrenim içindir; gerçek projelerde çoğu zaman **kapsülleme** ile property ve erişim kontrolü kullanılır (`4_Encapsulation.cs`).
