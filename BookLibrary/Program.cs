using System;
using System.Collections.Generic;
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

            PrintBooks(l);
        }
        private static void PrintBooks(Library library)
        {
            var ordered = library.Books
                .OrderByDescending(x => x.Price)
                .ThenBy(x => x.Author);
            foreach (var author in ordered.Select(x => x.Author).Distinct())
            {
                double sum = library.Books
                    .Where(x => x.Author == author)
                    .Sum(x => x.Price);
                Console.WriteLine("{0} -> {1:F2}", author, sum);
            }
        }
        private static Book ReadBook(string[] input)
        {
            Book book = new Book();
            book.Title = input[0];
            book.Author = input[1];
            book.Publisher = input[2];
            book.ReleaseDate = input[3];
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
        public string ReleaseDate { get; set; }
        public string ISBNNum { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
