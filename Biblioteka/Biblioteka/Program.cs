using System;
using System.Collections.Generic;

namespace Biblioteka
{
    class Program
    {
        public struct BookInfo
        {
            public string title;
            public string id;
            public string readerName;
            public DateTime dateTook;

            public double HoldingPeriod()

            {
                return (DateTime.Today - dateTook).TotalDays;

            }
        }

        static void Main(string[] args)
        {
            List<BookInfo> bookList = new List<BookInfo>();

            BookInfo book;
            book.title = "Knyga Sarasui1";
            book.id = "autorius1";
            book.readerName = "Justina";
            book.dateTook = new DateTime(2019, 1, 18);

            bookList.Add(book);

            book.title = "Knyga Sarasui2";
            book.id = "autorius2";
            book.readerName = "Vaida";
            book.dateTook = new DateTime(2019, 3, 18);

            bookList.Add(book);

            for (int i = 0; i < bookList.Count; i++)

            {
                Console.WriteLine(bookList[i].title);
                double days = bookList[i].HoldingPeriod();
                Console.WriteLine("This book is holding for {0} days", days);
            }
        }

    }
}
