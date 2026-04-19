# 6_Polymorphism.cs — Çok biçimlilik (Polymorphism)

Bu dosya, **aynı taban tür referansı** ile **farklı alt sınıf davranışlarının** çalışmasını gösterir; kalıtım + `virtual` / `override` kullanılır.

## Konular

### `virtual` ve `override`

- `Hayvan.SesCikar()` `virtual` olarak işaretlenir: alt sınıflar bunu **ezerek** kendi versiyonunu sağlar.
- `Kedi` ve `Kopek`, `SesCikar()` metodunu `override` eder.

### Çok biçimlilik (runtime polymorphism)

```text
Hayvan referansı = new Kedi(); 
referans.SesCikar();  // Çalışan gerçek tip Kedi olduğu için "Miyav!" üretilir.
```

Derleme zamanında tip `Hayvan`, çalışma zamanında ise **gerçek nesne** `Kedi` veya `Kopek` olduğu için doğru metot seçilir.

## Kodda yapılan işlemler

1. `PolymorphismRunner.Run()` üç referans oluşturur: ikisi alt sınıfa işaret eder, biri doğrudan `Hayvan`.
2. Hepsi üzerinden `SesCikar()` çağrılır; çıktılar sırasıyla kediye, köpeğe ve genel hayvana göre değişir.

## Özet

| Kavram      | Bu örnekte |
|-------------|------------|
| Late binding | `Hayvan` değişkeninde gerçek tip `Kedi`/`Kopek` |
| Genişletilebilirlik | Yeni hayvan = yeni sınıf + override |

---

*İpucu:* İsterseniz `SesCikar()` için `abstract` bir üst sınıf da kullanılabilir; bu örnek `virtual` ile varsayılan davranışı koruyor (`7_AbstractAndInterfaceClasses.cs` ile karşılaştırın).
