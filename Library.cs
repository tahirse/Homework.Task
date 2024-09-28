using static System.Reflection.Metadata.BlobBuilder;

namespace Homework.Task
{
    internal class Library
    {
        public string Name { get; set; }
        Book[] Books = new Book[0];
        Book newbook;
        public Library(string name)
        {
            Name = name;
        }
        public void AddBook(Book newBook)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = newBook;
            Console.WriteLine(newBook.Name + " " + " adinda kitab elave edildi");
        }
        public void RemoveBook(string name)
        {
            if (Books.Length == 0)
            {
                Console.WriteLine("Kitabxana boşdur!");
                return;
            }
            Book[] books = new Book[Books.Length - 1];
            int length = 0;

            for (int i = 0; i < Books.Length; i++)
            {

                if (!name.Equals(Books[i].Name, StringComparison.OrdinalIgnoreCase))
                {
                    newbook = new Book(Books[i].Name, Books[i].Price, Books[i].Genre);
                    books[length] = newbook;
                    length++;
                }

            }
            Books = books;
        }
        public Book FindBookName(string name)
        {
         
            foreach (var Book in Books)
            {
                if (name.Equals(Book.Name, StringComparison.OrdinalIgnoreCase))
                {
                    newbook = new Book(Book.Name, Book.Price, Book.Genre);
                    return newbook;
                }
            }
            return null;
        }
        public void FullInfo()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"Ad: {book.Name}, Qiymet: {book.Price}, Janr: {book.Genre}");
            }
        }


    }
}
