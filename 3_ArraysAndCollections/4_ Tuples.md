## 4_ Tuples.cs - Tuples

Tuples, birden fazla değeri tek bir nesne altında taşımak için kullanılır. Adlandırılabilir alanlar veya `Item1/Item2/...` üzerinden erişim mümkündür.

### Kod Akışı

- `Tuple.Create("John", 30, "New York")` ile üç elemanlı tuple üretilir.
- `person.Item1`, `person.Item2`, `person.Item3` ile değerler okunur.
- Ayrıca tuple “deconstruct” edilerek tek tek değişkenlere ayrılır:
  - `var (name, age, city) = person;`

### Ne Öğrendim?

- Tuple oluşturma
- Tuple değerlerine erişme
- Deconstruct (parçalayıp değişkenlere ayırma)

