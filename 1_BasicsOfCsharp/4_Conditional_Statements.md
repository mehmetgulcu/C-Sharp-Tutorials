## 4_Conditional_Statements.cs - Koşullar: `if/else` ve `switch`

Blog hissiyle söyleyeyim: programların akıllı olması için “şartlara göre” karar vermesi gerekir. C# bunun için `if/else` ve `switch` sunar.

### Kod Akışı

- `num` değeri üzerinden:
  - `if (num > 5)` durumunda bir mesaj yazılır,
  - `else if (num > 0 && num <= 5)` aralığı için farklı mesaj,
  - `else` kısmında kalan tüm durumlar ele alınır.

- Ardından `switch(num)` ile `case` etiketlerine göre başka bir akış kurulur.

### `switch` Ne İşe Yarar?

Bir değişkenin “birden fazla olası değeri” varsa `switch` okunabilirliği artırır. Ayrıca `break` ile hangi case’in bittiğini netleştirirsin.

### Ne Öğrendim?

- Boole şartlar ile dallanma (`if/else`)
- Aralık mantığı (`num > 0 && num <= 5`)
- `switch` ile case seçimi

