using System;
using System.Collections.Generic;
using System.Text;

namespace StaticPractice
{
    internal class Library
    {
        public int BookLimit { get; set; }
        public Book[] books;

        public Library(int bookLimit)
        {
            books = new Book[0];
            BookLimit = bookLimit;
        }

        public void AddBook(Book book)
        {
            if(books.Length < BookLimit)
            {
                Array.Resize(ref books, books.Length + 1);
                books[books.Length - 1] = book;
                return;
            }

            throw new Exception("Limit doldu");
        }

        public Book GetBookById(int id)
        {
            foreach (var book in books)
            {
                if(book.Id == id)
                    return book;
            }

            return null;
        }
    }
}
