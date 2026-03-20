public class Indexers
{
    public static void Run()
    {
        MyLibrary myLibrary = new MyLibrary();
        // Indexer sayesinde myLibrary[0] dizi gibi çalışır.
        myLibrary[0] = "Suç ve Ceza";
        Console.WriteLine(myLibrary[0]); // Dizi gibi okuduk
    }

    class MyLibrary
    {
        private string[] books = new string[100];

        // Bu blok indexer'i tanımlar: this[int index]
        public string this[int index]
        {
            // get: verilen index'teki değer döner
            get { return books[index]; }
            // set: verilen index'e yeni değer yazar
            set { books[index] = value; }
        }
    }
}