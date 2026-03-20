## 6_Indexers.cs - Indexer

Indexer; sınıfları “dizi gibi” kullanmanı sağlayan özel bir özelliktir. Yani `obj[0]` yazdığında arka planda `this[int index]` çalışır.

### Kod Akışı

- `MyLibrary` içinde `private string[] books = new string[100];` saklanır.
- `public string this[int index]` ile indexer tanımlanır:
  - `get`: `books[index]` değerini döndürür
  - `set`: `books[index]` değerini günceller
- Örnek kullanım:
  - `myLibrary[0] = "Suç ve Ceza";`
  - `Console.WriteLine(myLibrary[0]);`

### Ne Öğrendim?

- Indexer tanımı ve `this[...]` mantığı
- Indexer ile sınıfın daha “doğal” kullanılabilmesi

