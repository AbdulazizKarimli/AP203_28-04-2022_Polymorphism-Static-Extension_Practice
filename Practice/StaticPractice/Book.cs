using System;
using System.Collections.Generic;
using System.Text;

namespace StaticPractice
{
    internal class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, double price, string authorName, int pageCount) : base(name, price)
        {
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override void Sell()
        {
            Count--;
            TotalInCome += Price;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"AuthorName: {AuthorName} - PageCount: {PageCount} - Count: {Count} - TotalInCome: {TotalInCome}");
        }
    }
}
