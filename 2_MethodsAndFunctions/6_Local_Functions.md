## 6_Local_Functions.cs - Local Function

Local function; metot gövdesi içinde tanımladığınız küçük yardımcı fonksiyonlardır. Bu, “sadece o metotta kullanılacak” yardımcı kodları dışarıya taşımadan toplamanıza yardım eder.

### Kod Akışı

- `Run()` içinde `Calculate(int a, int b)` diye bir local function tanımlanıyor.
- Bu fonksiyon, `carpimKatsayisi` değişkenini dışarıdan kullanıyor.
- `Calculate(5, 10)` çağrılıyor ve sonuç konsola basılıyor.

### Blog Notu

Local function’ı, sadece `Run()` içinde anlam taşıyan küçük hesaplar için düşünün. Fazla sayıda metot eklemek yerine “ilgili yerde” tutarsınız.

### Ne Öğrendim?

- Local function tanımı
- Metot dışındaki değişkeni lokal fonksiyon içinde kullanma fikri

