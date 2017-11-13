using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library l = new Library();
            l.Books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                Book book = new Book();
                book = ReadBook(input);
                l.Books.Add(book);
            }

            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(),
                "dd.MM.yyyy", CultureInfo.InvariantCulture);
            PrintBooks(l, givenDate);
        }
        private static void PrintBooks(Library library, DateTime givenDate)
        {
            var ordered = library.Books
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title);
            foreach (var book in ordered.Where(x => x.ReleaseDate > givenDate))
            {
                Console.WriteLine("{0} -> {1}", book.Title, book.ReleaseDate.ToString("dd.MM.yyyy"));
            }
        }
        private static Book ReadBook(string[] input)
        {
            Book book = new Book();
            book.Title = input[0];
            book.Author = input[1];
            book.Publisher = input[2];
            book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBNNum = input[4];
            book.Price = double.Parse(input[5]);
            return book;
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBNNum { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
