# 1_TryCatchFinallyThrow.cs — Try, catch, finally ve throw

Bu dosya, C#’ta **istisnaları (exceptions)** yönetmenin temel bloklarını ve **bilinçli olarak hata fırlatmayı** gösterir.

## Konular

### `try`

- Hata çıkabilecek kod buraya yazılır.
- Bu örnekte kullanıcıdan `Console.ReadLine()` ile giriş alınıp `Convert.ToInt32` ile sayıya çevrilir; geçersiz metin **`FormatException`** üretebilir.

### `throw`

- Koşul sağlandığında **siz** bir istisna oluşturup yukarı fırlatabilirsiniz.
- `sayi < 0` ise `throw new ArgumentException("Negatif sayı giremezsiniz!");` çalışır.

### `catch`

- Belirli istisna **türüne** göre ayrı bloklar yazılabilir (sıra önemlidir: daha spesifik olanlar önce).
- **`FormatException`:** Sayı formatı uygun değilse kullanıcı dostu mesaj ve `ex.Message`.
- **`ArgumentException`:** Negatif sayı kuralınız tetiklendiğinde mesaj yazdırılır.

### `finally`

- İstisna oluşsun veya oluşmasın **her zaman** çalışır.
- Bu örnekte try-catch akışının bittiğini bildiren sabit bir çıktı verir; gerçek projede dosya kapatma, kilidi bırakma gibi “mutlaka yapılacak” işler için kullanılır.

## Kodda yapılan işlemler

1. Kullanıcıdan sayı istenir ve dönüşüm yapılır.
2. Negatifse `ArgumentException` fırlatılır.
3. Geçersiz girişte `FormatException`, negatifte `ArgumentException` yakalanır.
4. Her senaryoda `finally` içinde tamamlanma mesajı yazılır.

## Özet

| Anahtar kelime | Rol |
|----------------|-----|
| `try` | Riskli kod |
| `catch` | Yakalama ve kullanıcıya/rehbere mesaj |
| `finally` | Her durumda çalışan temizlik / bilgi |
| `throw` | İş kuralını ihlal eden durumda istisna üretme |

---

*İpucu:* Üretim kodunda kullanıcı girdisi için `int.TryParse` ve doğrulama sıklıkla try-catch’ten önce tercih edilir; bu dosya **blokların çalışma sırasını** öğretmek içindir.
