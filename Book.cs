namespace Homework.Task
{
    public class Book:Product
    {
        public string Genre { get; set; }
        public Book(string name,double price,string genre) :base(name,price)
        {
            Genre = genre;
        }

    }
}
