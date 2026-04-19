# Program.cs — Uygulama giriş noktası

Bu dosya, istisna işleme örneklerinin çalıştırıldığı konsol uygulamasının `Main` metodunu içerir.

## Ne yapar?

- Başlangıçta konsola kısa bir bilgi mesajı yazar.
- Hangi örneği görmek istediğinize göre ilgili `Run()` çağrısı aktif tutulur; diğeri yorum satırına alınır.

## Bu projedeki akış

| Çağrı | Dosya | Konu |
|--------|--------|------|
| `TryCatchFinallyThrow.Run()` | `1_TryCatchFinallyThrow.cs` | try / catch / finally / throw |
| `CustomExceptionRunner.Run()` | `2_ CustomException.cs` | Özel exception sınıfı ve yakalama |

Örnek varsayılan kodda `CustomExceptionRunner.Run()` açık; diğerini denemek için satırların başındaki `//` işaretlerini değiştirin.

## İlgili konular

- **Tek giriş noktası:** `static void Main(string[] args)`
- **Modüler öğrenme:** Her `.cs` bir alt konuyu temsil eder; `Program` üzerinden sırayla çalıştırılabilir.
