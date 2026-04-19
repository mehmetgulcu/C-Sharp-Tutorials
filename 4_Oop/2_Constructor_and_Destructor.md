# 2_Constructor_and_Destructor.cs — Yapıcı ve yıkıcı

Bu dosya, nesne **doğduğunda** ve **bellekten kaldırılmadan önce** otomatik çalışan özel metotlara odaklanır.

## Konular

### Constructor (yapıcı)

- Sınıf adıyla aynı isimde özel bir metottur.
- `new Person("Mehmet", 30)` yazıldığında çalışır.
- Genelde alanların veya property’lerin **başlangıç değerlerini** ayarlamak için kullanılır.

Bu örnekte `Person(string name, int age)` oluşturulunca konsola `"Constructor çağrıldı."` yazılır ve `Name`, `Age` atanır.

### Destructor (yıkıcı)

- `~Person()` şeklinde tanımlanır.
- Nesne çöp toplayıcı (GC) tarafından temizlenmeden önce çalışabilir; **tam zamanı garanti edilmez**.
- Modern C#’ta kaynak yönetimi için çoğu zaman `IDisposable`, `using` veya `try/finally` tercih edilir; destructor daha çok akademik/teorik bağlamda gösterilir.

## Kodda yapılan işlemler

1. `Person` için parametreli constructor tanımlanır.
2. `Run()` içinde iki kez `new Person(...)` ile nesne oluşturulur; her seferinde constructor çalışır.
3. Destructor çıktısı program sonuna yakın veya GC zamanlamasına bağlı olarak görülebilir.

## Özet

| Kavram        | Rol |
|---------------|-----|
| Constructor   | Nesne oluşturulurken başlatma |
| Destructor    | Temizlik fırsatı (zamanı kesin değil) |

---

*İpucu:* Üretim kodunda dosya, ağ veya veritabanı gibi kaynakları destructor ile değil, `using` veya explicit dispose ile serbest bırakmak daha güvenilirdir.
