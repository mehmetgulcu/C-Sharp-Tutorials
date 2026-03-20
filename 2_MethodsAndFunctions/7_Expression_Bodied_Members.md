## 7_Expression_Bodied_Members.cs - Expression-Bodied Members

Bu dosya, “tek bir ifadeye indirgenebilen” metotları daha kısa yazma fikrini gösteriyor.

### Kod Akışı

- `Run()` içinde `Add(5, 10)` çağrılıyor.
- `Add` metodu `=>` kullanarak tek satırda değer döndürüyor:
  - `public static int Add(int a, int b) => a + b;`

### Ne Öğrendim?

- Expression-bodied method yazımı: `metot => ifade;`
- Çok basit dönüş işlemlerinde okunabilirliği artırma

