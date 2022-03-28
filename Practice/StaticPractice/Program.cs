using System;

namespace StaticPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("test", 12, "test testov", 5);
            Book book1 = new Book("test1", 11, "test1 testov", 2);

            //Library library = new Library(1);
            Library library = new Library(3);

            //try
            //{
            //    library.AddBook(book);
            //    library.AddBook(book1);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            library.AddBook(book);
            library.AddBook(book1);

           //Book book2 = library.GetBookById(1);
           // book2.ShowInfo();

            library.GetBookById(1).ShowInfo();
        }
    }
}
