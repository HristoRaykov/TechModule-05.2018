using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
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
                int isbnNumber = int.Parse(input[4]);
                double price = double.Parse(input[5]);
                books.Add(new Book(title, author, publisher, releaseDate, isbnNumber, price));
            }

            DateTime beginDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library lib = new Library("My Library", books);

            Dictionary<string, DateTime> titles = new Dictionary<string, DateTime>();

            foreach (var book in books)
            {
                if (!titles.ContainsKey(book.Title))
                {
                    titles.Add(book.Title, book.ReleaseDate);
                }
                titles[book.Title] = book.ReleaseDate;
            }
            titles = titles.OrderBy(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key).ToDictionary(t => t.Key, t => t.Value);


            foreach (var kvp in titles.Where(kvp => kvp.Value > beginDate))
            {

                Console.WriteLine($"{kvp.Key} -> {kvp.Value.ToString("dd.MM.yyyy")}");
            }
            Console.WriteLine();
        }
    }

    class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Publisher { get; }
        public DateTime ReleaseDate { get; }
        public int isbnNumber { get; }
        public double Price { get; }

        public Book(string title, string author, string publisher, DateTime releaseDate, int isbnNumber, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.isbnNumber = isbnNumber;
            this.Price = price;
        }
    }

    class Library
    {
        public string Name { get; }
        public List<Book> books { get; set; }

        public Library(string name, List<Book> books)
        {
            this.Name = name;
            this.books = books;
        }
    }
}
