## 4_Ref_Out.cs - `ref` ve `out`

`ref` ve `out`, metot parametresi olarak dışarıdaki değerleri metot içinde “etkilemek” için kullanılır. İkisi de bu fikri taşır ama niyetleri farklıdır:

- `ref`: Metota giderken değer kesin olarak bellidir; metot içi değişiklik çağırana geri yansır.
- `out`: Metot çalışmadan önce çağıran tarafın “değer set etmeye” gerek yoktur; metot, parametreyi kendisi atar.

### Kod Akışı

- `Swap(ref number1, ref number2)` iki değişkenin yerini değiştirir.
- `CalculateSquare(4, out result)` verilen sayının karesini hesaplar ve `out result` içine yazar.

### Ne Öğrendim?

- Parametreleri referansla aktarmak
- `out` ile “hesap sonucu döndürme” yaklaşımı

