# Program.cs — Uygulama giriş noktası

Bu dosya, konsol uygulamasının `Main` metodunu içerir ve tüm OOP örneklerinin merkezi çalıştırıcısıdır.

## Ne yapar?

- Uygulama başladığında konsola kısa bir bilgi mesajı yazar.
- Aynı projede birden fazla örnek sınıf olduğu için, hangi konuyu görmek istiyorsanız ilgili `Run()` çağrısının yorumunu (`//`) kaldırıp projeyi çalıştırırsınız.

## Tutorial akışı

1. Çalıştırmak istediğiniz konunun satırını bulun (örneğin `ClassAndObject.Run();`).
2. Başındaki `//` işaretini silin.
3. Diğer `Run()` çağrılarını yorum satırı yaparak tek bir örnekle çalışın.

## İlgili konular

- **Console uygulaması yapısı:** `static void Main(string[] args)` giriş noktasıdır.
- **Modüler öğrenme:** Her `.cs` dosyası bir konuyu temsil eder; `Program` üzerinden seçerek sırayla veya ihtiyaca göre deneyebilirsiniz.

---

*İpucu:* Birden fazla `Run()` aynı anda aktif olursa çıktılar karışabilir; öğrenirken tek örnek açık tutmak daha okunaklıdır.
