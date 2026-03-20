## 5_Optionel_Parameters.cs - Optional Parameters (İsteğe Bağlı)

İsteğe bağlı parametreler sayesinde metotları farklı sayıda argümanla çağırabilirsiniz. Metot çağrısında argüman vermezseniz derleyici tanımlı varsayılan değeri kullanır.

### Kod Akışı

- `GetSum(int a, int b = 0)`:
  - `b` verilmezse otomatik olarak `0` olur.
- Kullanıcı ikinci sayıyı boş bırakırsa örnek, `b`yi `0` kabul ederek toplamı hesaplar.

### Ne Öğrendim?

- Varsayılan parametre değeri tanımlamak (`b = 0`)
- Tek metot ile hem tek hem çift argümanlı kullanım sağlamak

