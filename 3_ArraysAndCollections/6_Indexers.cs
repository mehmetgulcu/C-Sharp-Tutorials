public class Indexers
{
    public static void Run()
    {
        MyLibrary myLibrary = new MyLibrary();
        myLibrary[0] = "Suç ve Ceza"; // Dizi gibi atama yaptık
        Console.WriteLine(myLibrary[0]); // Dizi gibi okuduk
    }

    class MyLibrary
    {
        private string[] books = new string[100];

        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
    }
}