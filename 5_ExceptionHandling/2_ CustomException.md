# 2_ CustomException.cs — Özel istisna (custom exception)

Bu dosya, `Exception` sınıfından **türeyen kendi istisna türünüzü** tanımlayıp iş kurallarında `throw` ve `catch` ile nasıl kullanacağınızı gösterir.

## Konular

### Özel istisna sınıfı: `YetersizBakiyeException`

- `Exception` tabanından kalıtım — .NET ekosisteminde tanınan standart istisna modeli.
- **`base(mesaj)`:** Üst sınıfa açıklama metnini iletir; `Message` property üzerinden okunur.
- **`MevcutBakiye`:** Bu hataya özel ek bağlam (örnekte çekim anındaki bakiye); yakalayan kod `ex.MevcutBakiye` ile okuyabilir.

### İş kuralı: `BankaHesabi.ParaCek`

- Çekilecek tutar bakiyeden büyükse `YetersizBakiyeException` fırlatılır.
- Geçerliyse bakiye güncellenir.

### Çalıştırıcı: `CustomExceptionRunner.Run`

- `try` içinde bilinçli olarak hataya düşecek çağrı: `ParaCek(1000)` (başlangıç bakiyesi 500).
- **`catch (YetersizBakiyeException ex)`:** Önce özel tür yakalanır; hem `Message` hem `MevcutBakiye` kullanılır.
- **`catch (Exception ex)`:** Diğer beklenmedik durumlar için genel yakalayıcı (bu örnekte özel türden sonra gelir).

## Kodda yapılan işlemler

1. `YetersizBakiyeException` tanımlanır.
2. `BankaHesabi` ile bakiye ve `ParaCek` kuralı modellenir.
3. `Run()` içinde try-catch ile özel istisna yakalanır ve bağlamlı mesaj yazdırılır.

## Özet

| Kavram | Bu örnekte |
|--------|------------|
| Custom exception | `YetersizBakiyeException : Exception` |
| Ek veri | `MevcutBakiye` |
| throw | Koşul ihlalinde `ParaCek` içinde |
| catch sırası | Önce özel, sonra genel (`Exception`) |

---

*İpucu:* Özel istisna adları genelde `...Exception` ile biter; çok yaygın ve beklenen durumlar için bazen önce `bool` veya `Result` tipi pattern’leri düşünülür — domain ve ekip standardına göre seçilir.
