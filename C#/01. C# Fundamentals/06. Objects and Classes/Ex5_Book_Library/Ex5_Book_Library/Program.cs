using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex5_Book_Library
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ISBN { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                int isbn = int.Parse(input[4]);
                double price = double.Parse(input[5]);

                Book temp = new Book();
                temp.Title = title;
                temp.Author = author;
                temp.Publisher = publisher;
                temp.ReleaseDate = releaseDate;
                temp.ISBN = isbn;
                temp.Price = price;

                books.Add(temp);
            }

            Library a = new Library() { Name = "", Books = books };

            Dictionary<string, double> output = new Dictionary<string, double>();

            foreach (Book book in a.Books)
            {
                if (!output.ContainsKey(book.Author)) output.Add(book.Author, 0);
                output[book.Author] += book.Price;
            }

            foreach (KeyValuePair<string, double> b in output.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", b.Key, b.Value);
            }
            
        }
    }
}
