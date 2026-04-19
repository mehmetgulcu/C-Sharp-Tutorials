# 9_DifferencesbetweenStructandClass.cs — Struct ve class farkı

Bu dosya, **referans tipi** (`class`) ile **değer tipi** (`struct`) arasındaki **kopyalama davranışını** sayılarla gösterir.

## Konular

### Class (`SinifNokta`)

- `SinifNokta s2 = s1` ataması **aynı nesneyi** işaret eden referansı kopyalar (stack’te referans, heap’te tek nesne).
- `s2.x = 20` yaptığınızda **heap’teki tek nesne** değişir; `s1.x` okunduğunda da **20** görünür.

### Struct (`StructNokta`)

- `StructNokta st2 = st1` ataması **alanların değer kopyası**dır; yeni bir struct örneği gibi düşünülebilir.
- `st2.x = 20` sadece kopyayı değiştirir; **`st1.x` 10 kalır**.

## Kodda yapılan işlemler

1. İki class değişkeni aynı nesneyi paylaştığı için ilk `Console.WriteLine(s1.x)` **20** yazdırır.
2. İki struct değişkeni bağımsız kopya olduğu için ikinci `Console.WriteLine(st1.x)` **10** yazdırır.

## Özet

| Tür     | Kopyalama sonucu (bu örnekte) |
|---------|-------------------------------|
| `class` | Aynı nesne — birini değiştirince diğeri etkilenir |
| `struct`| Değer kopyası — birini değiştirince diğeri genelde etkilenmez |

---

*Not:* Struct’lar genelde küçük, immutable benzeri veri için uygundur; büyük veya kalıtım gerektiren modellerde `class` daha yaygındır. Varsayılan parametre davranışları da farklılık gösterebilir; bu dosya özellikle **atama sonrası mutasyon** farkına odaklanır.
