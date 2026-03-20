## 3_Overloading.cs - Method Overloading (Aşırı Yükleme)

Overloading, aynı isimle birden fazla metot tanımlamanızı sağlar. Bu sayede farklı türlerdeki girişlere uygun davranışı seçersiniz.

### Kod Akışı

- `GetSum(int a, int b)` -> `int` toplar.
- `GetSum(double c, double d)` -> `double` toplar.
- `Run()` içinde hem `int` hem de `double` ile örnek çağrılar yapılıyor.

### Blog Gibi Düşün

Tek bir “iş” var: toplama. Ama toplama farklı sayısal türlerle yapılacak. Derleyici, çağrı sırasında verdiğiniz argüman tipine göre doğru metodu seçer.

### Ne Öğrendim?

- Aynı isimde farklı imzalar (signature) ile metotlar yazabilmek.
- Derleyicinin çağrı tipine göre doğru overload’ı seçmesi.

