## Program.cs - Çalıştırma Seçimi

`1_BasicsOfCsharp` projesinde her konu bir `Run()` metodu ile ayrı ayrı çalıştırılıyor. `Program.cs` ise “hangi konuyu çalıştırıyorum?” sorusunun cevabı.

### Kod Ne Yapıyor?

- Konsola bir mesaj yazdırıyor: `Dotnet Console uygulaması çalışıyor.`
- Diğer örnekleri açmak için ilgili `Run()` çağrılarını yorum satırından çıkarman gerekiyor.

### Neden Böyle?

Tutorial projelerinde tek bir `Main()` metodu olur; ama farklı konuları ayrı ayrı görmek istersin. Bu yüzden örnekler `Run()` metotlarında toplanır ve `Program.cs` ile seçim yapılır.

