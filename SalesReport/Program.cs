using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            var salesByTown = new SortedDictionary<string, decimal>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                var s = ReadSale(input);
                string town =  s.Town;
                decimal total = s.Price * s.Quantity;
                if (!salesByTown.ContainsKey(town))
                {
                    salesByTown.Add(town, 0);
                }
                salesByTown[town] += total;
            }

            foreach (var pair in salesByTown)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:F2}");
            }
        }

        public static Sale ReadSale(string[] input)
        {
            Sale s = new Sale();
            s.Town = input[0];
            s.Product = input[1];
            s.Price = decimal.Parse(input[2]);
            s.Quantity = decimal.Parse(input[3]);
            return s;
        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
