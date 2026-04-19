public class AccessModifiers
{
    class Person
    {
        // Access Modifiers (Erişim Belirleyiciler)
        // C#'ta erişim belirleyiciler, sınıf üyelerinin (değişkenler, metotlar, özellikler vb.) erişilebilirliğini kontrol etmek için kullanılır. 
        // Erişim belirleyiciler, bir üyenin hangi kod tarafından erişilebileceğini belirler.

        // Public: Her yerden erişilebilir.
        public string Name { get; set; }

        // Private: Sadece tanımlandığı sınıf içinde erişilebilir.
        private int Age { get; set; }

        // Protected: Sadece tanımlandığı sınıf ve o sınıftan türetilen sınıflar içinde erişilebilir.
        protected string Address { get; set; }

        // Internal: Aynı assembly içinde her yerden erişilebilir.
        internal string PhoneNumber { get; set; }

        // Protected Internal: Aynı assembly içinde her yerden ve farklı assembly'lerde türetilen sınıflar içinde erişilebilir.
        protected internal string Email { get; set; }
    }
    public static void Run()
    {
        Console.WriteLine("Access Modifiers örneği çalışıyor.");

        Person person = new Person();
        person.Name = "Mehmet"; // Public olduğu için erişilebilir
        // person.Age = 30; // Private olduğu için erişilemez
        // person.Address = "İstanbul"; // Protected olduğu için erişilemez
        person.PhoneNumber = "1234567890"; // Internal olduğu için erişilebilir
        person.Email = "mehmet@example.com"; // Protected Internal olduğu için erişilebilir 
        Console.WriteLine($"Ad: {person.Name}, Telefon: {person.PhoneNumber}, Email: {person.Email}");
    }
}