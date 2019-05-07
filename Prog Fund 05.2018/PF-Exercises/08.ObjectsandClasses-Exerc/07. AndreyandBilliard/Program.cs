using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyandBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> products = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string product = input[0];
                double price = double.Parse(input[1]);
                if (!products.ContainsKey(product))
                {
                    products.Add(product,0.0);
                }
                products[product] = price;
            }

            SortedDictionary<string, Dictionary<string, int>> clients = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string line = Console.ReadLine();                
                if (line.Equals("end of clients"))
                {
                    break;
                }
                string[] input = line.Split('-');
                string custumer = input[0];
                string[] token = input[1].Split(',');
                string orderedItem = token[0];
                int quantity = int.Parse(token[1]);
                if (products.ContainsKey(orderedItem)==false)
                {
                    continue;
                }

                if (clients.ContainsKey(custumer)==false)
                {
                    clients.Add(custumer,new Dictionary<string, int>());
                }

                Dictionary<string,int> orders = clients[custumer];
                if (orders.ContainsKey(orderedItem) == false)
                {
                    orders.Add(orderedItem,0);
                }
                orders[orderedItem] += quantity;
                //clients[custumer] = orders;
            }
            double totalSumOfBills = 0;
            foreach (var customer in clients)
            {
                double bill = 0;
                Console.WriteLine($"{customer.Key}");
                Dictionary<string, int> orders = customer.Value;
                foreach (var order in orders)
                {
                    Console.WriteLine($"-- {order.Key} - {order.Value}");
                    double price = products[order.Key];
                    bill += 1.0*order.Value*price;
                }
                Console.WriteLine($"Bill: {bill:f2}");
                totalSumOfBills += bill;
            }
            Console.WriteLine($"Total bill: {totalSumOfBills:f2}");

            Console.WriteLine();
        }
    }
}
