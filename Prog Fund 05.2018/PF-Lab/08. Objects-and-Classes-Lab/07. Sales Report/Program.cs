using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string town = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);
                double quantity = double.Parse(input[3]);
                Sale sale = new Sale(town, product, price, quantity);
                sales.Add(sale);
            }

            List<string> towns = sales.Select(sale => sale.Town).Distinct().ToList();
            towns.Sort();
            List<double> salesByTown = new List<double>();

            foreach (var town in towns)
            {
                double sum = sales.Where(sale => sale.Town == town).Sum(sale => sale.MoneySpend);
                salesByTown.Add(sum);
            }

            for (int i = 0; i < towns.Count; i++)
            {
                Console.WriteLine($"{towns[i]} -> {salesByTown[i]:f2}");
            } 

            //SortedDictionary<string, double> sales = new SortedDictionary<string, double>();

            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split();
            //    string town = input[0];
            //    string product = input[1];
            //    double price = double.Parse(input[2]);
            //    double quantity = double.Parse(input[3]);
            //    Sale sale = new Sale(town, product, price, quantity);

            //    if (sales.ContainsKey(sale.Town) == false)
            //    {
            //        sales.Add(sale.Town, 0);
            //    }
            //    sales[sale.Town] += sale.MoneySpend;
            //}

            //foreach (var sale in sales)
            //{
            //    Console.WriteLine($"{sale.Key} -> {sale.Value:f2}");
            //}



        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double MoneySpend
        {
            get
            {
                return this.Price * this.Quantity;
            }
            set { }
        }
        public Sale(string town, string product, double price, double quantity)
        {
            this.Town = town;
            this.Product = product;
            this.Price = price;
            this.Quantity = quantity;
        }


    }
}
