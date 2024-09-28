namespace Homework.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Library library = new Library("Axundov");
            Console.WriteLine("                                           Axundov adina Kitabxana");
            while (true)
            {
                Console.WriteLine("1. Kitab elave et");

                Console.WriteLine("2. Kitab sil");

                Console.WriteLine("3. Bütün kitablara bax");

                Console.WriteLine("4. Seçilmiş kitaba bax (ada göre)");

                Console.WriteLine("0. Exit");

                Console.WriteLine("Seciminizi edin: ");

                var data = Console.ReadLine();

                switch (data)
                {
                    case "1":
                        Console.Write("Kitab adi: ");
                        string name = Console.ReadLine();
                        Console.Write("Qiymet: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Janr: ");
                        string genre = Console.ReadLine();
                        library.AddBook(new Book(name, price, genre));
                        break;

                    case "2":
                        Console.Write("Silinecek kitabin adi: ");
                        string bookToRemove = Console.ReadLine();
                        library.RemoveBook(bookToRemove);
                        break;

                    case "3":
                        ;library.FullInfo();
                        break;

                    case "4":
                        Console.Write("Baxilacaq kitabin adi: ");
                        string bookName = Console.ReadLine();
                        var foundBook = library.FindBookName(bookName);
                        if (foundBook != null)
                        {
                            Console.WriteLine($"Ad: {foundBook.Name}, Qiymet: {foundBook.Price}, Janr: {foundBook.Genre}");
                        }
                        else
                        {
                            Console.WriteLine("Kitab tapilmadi.");
                        }
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Yanliş seçim. Yeniden cehd edin.");
                        break;
                }





                //Book book;

                //do
                //{
                //    Console.Write("Kitabin Ad:");
                //    string name = Console.ReadLine();
                //    Console.WriteLine();

                //    Console.Write("Kitabin qiymeti:");
                //    double price = double.Parse(Console.ReadLine());
                //    Console.WriteLine();


                //    Console.Write("Kitabin Janri:");
                //    string genre = Console.ReadLine();

                //    book = new Book(name, price, genre);
                //    library.AddBook(book);
                //}
                //while (Console.ReadLine() == "yes");



                ////string data = "Tahir";

                ////library.RemoveBook(data);

                //string data = "Tahir";
                //Book bookfind = library.FindBookName(data);

                //if (bookfind != null) 
                //{
                //    Console.WriteLine(bookfind.Name);
                //    Console.WriteLine(bookfind.Price);
                //    Console.WriteLine(bookfind.Genre);
                //}
                //else 
                //{
                //    Console.WriteLine($"{data} adda kitab yoxdur!");
                //}

























                //Book book = new Book("Axtarish", 55, "Detektiv");
                //Product product = new Product("", 5);
                //library.AddBook(new Book("Cinayet",5,"Detektiv"));
                //library.FindBookName("Algoritm");
                //library.RemoveBook("Ali ve Nino");


            }
        }
    }
}

