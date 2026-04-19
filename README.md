## C# Tutorials

Bu repo, C# konularını örnek kodlarla pekiştirmek için oluşturulmuş konsol uygulaması projelerinden oluşur. Her konu klasöründe ilgili `.cs` dosyasıyla **aynı adda** tutorial mantığında yazılmış `.md` dosyaları bulunur; teoriyi okuyup yanındaki kodu çalıştırarak ilerleyebilirsiniz.

Önerilen sıra: `1_BasicsOfCsharp` → `2_MethodsAndFunctions` → `3_ArraysAndCollections` → `4_Oop` → `5_ExceptionHandling`.

---

## Tutorial dokümanları

### `1_BasicsOfCsharp/`

- `1_BasicsOfCsharp/BasicsOfCsharp.md`
- `1_BasicsOfCsharp/Program.md`
- `1_BasicsOfCsharp/1_Basics.md`
- `1_BasicsOfCsharp/2_ConstsAndEnums.md`
- `1_BasicsOfCsharp/3_Operators.md`
- `1_BasicsOfCsharp/4_Conditional_Statements.md`
- `1_BasicsOfCsharp/5_Loops.md`
- `1_BasicsOfCsharp/6_Input_Output.md`

### `2_MethodsAndFunctions/`

- `2_MethodsAndFunctions/MethodsAndFunctions.md`
- `2_MethodsAndFunctions/Program.md`
- `2_MethodsAndFunctions/1_MethodsAndCalls.md`
- `2_MethodsAndFunctions/2_ParametersAndReturn.md`
- `2_MethodsAndFunctions/3_Overloading.md`
- `2_MethodsAndFunctions/4_Ref_Out.md`
- `2_MethodsAndFunctions/5_Optionel_Parameters.md`
- `2_MethodsAndFunctions/6_Local_Functions.md`
- `2_MethodsAndFunctions/7_Expression_Bodied_Members.md`

### `3_ArraysAndCollections/`

- `3_ArraysAndCollections/Program.md`
- `3_ArraysAndCollections/1_Arrays.md`
- `3_ArraysAndCollections/2_Generic_Collections.md`
- `3_ArraysAndCollections/3_ArrayListAndHashtable.md`
- `3_ArraysAndCollections/4_ Tuples.md`
- `3_ArraysAndCollections/5_Nullable_Types.md`
- `3_ArraysAndCollections/6_Indexers.md`
- `3_ArraysAndCollections/7_SpanAndMemory.md`

### `4_Oop/`

- `4_Oop/Program.md`
- `4_Oop/1_class_and_object.md`
- `4_Oop/2_Constructor_and_Destructor.md`
- `4_Oop/3_Access_Modifiers.md`
- `4_Oop/4_Encapsulation.md`
- `4_Oop/5_Inheritance.md`
- `4_Oop/6_Polymorphism.md`
- `4_Oop/7_AbstractAndInterfaceClasses.md`
- `4_Oop/8_Sealed_Static_Partial_Class.md`
- `4_Oop/9_DifferencesbetweenStructandClass.md`

### `5_ExceptionHandling/`

- `5_ExceptionHandling/Program.md`
- `5_ExceptionHandling/1_TryCatchFinallyThrow.md`
- `5_ExceptionHandling/2_ CustomException.md`

---

## Çalıştırma

İlgili proje klasörüne girip:

```bash
cd 1_BasicsOfCsharp   # veya 2_MethodsAndFunctions, 3_ArraysAndCollections, 4_Oop, 5_ExceptionHandling
dotnet run
```

**Not:** Bazı projelerde `Program.cs` içinde örnekler `Run()` çağrılarıyla seçilir; çalıştırmak istediğiniz konunun çağrısının yorumunun (`//`) kaldırıldığından emin olun; gerekiyorsa diğer `Run()` satırlarını yorumlayarak tek örnek çalıştırın.
