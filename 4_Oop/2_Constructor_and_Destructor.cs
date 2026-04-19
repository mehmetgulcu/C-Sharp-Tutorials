public class ConstructorAndDestructor
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Constructor çağrıldı.");
        }

        // Destructor
        ~Person()
        {
            Console.WriteLine("Destructor çağrıldı.");
        }
    }
    public static void Run()
    {
        Console.WriteLine("Constructor ve Destructor örneği çalışıyor.");

        // Constructor ve Destructor nedir?
        // Constructor, bir sınıfın yeni bir örneği oluşturulduğunda otomatik olarak çağrılan özel bir metottur. Nesnenin başlangıç durumunu ayarlamak için kullanılır.
        // Destructor ise, bir nesne bellekten kaldırılmadan önce otomatik olarak çağrılan özel bir metottur. Genellikle kaynakları serbest bırakmak için kullanılır.

        // Constructor örneği
        Person person1 = new Person("Mehmet", 30);
        Console.WriteLine($"Ad: {person1.Name}, Yaş: {person1.Age}");

        // Destructor örneği
        Person person2 = new Person("Ayşe", 25);
        Console.WriteLine($"Ad: {person2.Name}, Yaş: {person2.Age}");
    }
}