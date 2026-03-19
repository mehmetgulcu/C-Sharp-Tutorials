## MethodsAndFunctions Tutorials

`2_MethodsAndFunctions` projesi; C# dilinde metotların (functions) nasıl tanımlandığını ve nasıl kullanıldığını örnekler üzerinden anlatır.

> Proje içinde `Program.cs` bazı `Run()` çağrılarını yorum satırı olarak bırakır. Çalıştırmak istediğiniz örneğin `Run()` çağrısını aktif hale getirin.

---

### 1) Metot Çağrısı (`1_MethodsAndCalls.cs`)

Metotlar; tekrar eden işleri tek bir yerde toplamanıza yardımcı olur. Bu örnekte `Run()` metodu, aynı sınıf içindeki `CallMethod()` metotunu çağırır.

- `static` metotlar; sınıftan nesne üretmeden çağrılabilir.
- Metot çağrısı için metot adından sonra parantez kullanılır: `CallMethod()`.

---

### 2) Parametreler ve Return (`2_ParametersAndReturn.cs`)

Parametreli metotlarda dışarıdan veri alıp, işlem yapıp sonucu `return` ile geri gönderebilirsiniz.

- `GetSum(int a, int b)` iki parametre alır ve `a + b` sonucunu döndürür.
- Örnekte kullanıcıdan alınan girişler `Console.ReadLine()` ile okunuyor; ardından `int.Parse(...)` ile sayıya çevriliyor.
- `Run()` içinde null kontrolü yapılarak `Console.ReadLine()` `null` gelirse işlem güvenli şekilde sonlandırılıyor.

---

### 3) Method Overloading (Aşırı Yükleme) (`3_Overloading.cs`)

Overloading; aynı isimde metotların farklı parametre türleri/şekilleriyle tanımlanmasıdır.

Bu örnekte:

- `GetSum(int a, int b)` -> iki `int` toplamlar.
- `GetSum(double c, double d)` -> iki `double` toplamlar.

Derleyici, çağrıdaki argüman tipine göre doğru overload’ı seçer.

---

### 4) `ref` ve `out` Kullanımı (`4_Ref_Out.cs`)

Bazı durumlarda metot parametresi olarak gönderdiğiniz değerlerin çağıran tarafa geri yazılmasını istersiniz.

Bu örnekte iki farklı yaklaşım gösterilir:

- `ref`: Değer metota gider, metot içinde değiştirilir ve bu değişiklik çağırana yansır.
- `out`: Çağıran taraf `out` parametresinin değerinin metot tarafından kesin olarak atanacağını varsayar. Metot içinde atama yapılır.

Örnekler:

- `Swap(ref number1, ref number2)` -> iki değeri değiştirir.
- `CalculateSquare(int number, out int square)` -> karesini hesaplayıp `out` ile döndürür.

---

### 5) Optional Parameters (İsteğe Bağlı Parametre) (`5_Optionel_Parameters.cs`)

İsteğe bağlı parametrelerde metot çağrısında ilgili argüman verilmezse derleyici varsayılan değeri kullanır.

Örnekte:

- `GetSum(int a, int b = 0)` metodu; `b` verilmezse `0` kabul eder.
- Kullanıcı ikinci sayıyı boş bırakırsa kod, `b`’yi 0’da tutarak toplamı hesaplar.

Bu sayede hem tek parametreyle hem de iki parametreyle çağrı yapabilirsiniz.

---

### 6) Local Functions (Yerel Fonksiyonlar) (`6_Local_Functions.cs`)

Local function; başka bir fonksiyon/metot bloğu içinde tanımlanan yardımcı fonksiyonlardır.

Bu örnekte `Run()` içinde tanımlanan `Calculate(int a, int b)`:

- `carpimKatsayisi` değişkenini dışarıdan (closure gibi) kullanır.
- `(a + b) * carpimKatsayisi` sonucunu döndürür.

Local functions; küçük yardımcı işlemleri ilgili metot kapsamında tutmak için kullanışlıdır.

---

### 7) Expression-Bodied Members (`7_Expression_Bodied_Members.cs`)

Expression-bodied method; metodu tek bir ifade ile kısa ve okunabilir biçimde yazmanıza olanak tanır.

Örnek:

- `public static int Add(int a, int b) => a + b;`

Bu, `return a + b;` yazımının daha kısa halidir.

---

## Notlar

- Metot isimlerini ve parametrelerini “hangi amaçla” kullanıldığını anlatacak şekilde seçmek kod okunabilirliğini artırır.
- `ref/out` kullanımında; amaç sadece performans değil, “metnin çağıran tarafın değerini etkileme isteği” olmalıdır.

