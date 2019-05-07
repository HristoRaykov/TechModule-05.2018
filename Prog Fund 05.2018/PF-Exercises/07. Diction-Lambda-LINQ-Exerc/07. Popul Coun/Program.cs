using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Popul_Coun
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dictionary<string, long>>> countries = new Dictionary<string, List<Dictionary<string, long>>>();


            while (true)
            {
                string[] input = Console.ReadLine().Split('|');
                if (input[0].Equals("report"))
                {
                    break;
                }
                string city = input[0];
                string country = input[1];
                int population = int.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new List<Dictionary<string, long>>(2) {
                        new Dictionary<string, long>(),
                        new Dictionary<string, long>(1)});
                }

                Dictionary<string, long> cities = countries[country][0];

                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, population);
                }

                Dictionary<string, long> countryPopulation = countries[country][1];
                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation.Add(country, 0);
                }
            }                       

            foreach (var country in countries.Keys)
            {
                Dictionary<string, long> cities = countries[country][0];
                Dictionary<string, long> countryPopulation = countries[country][1];
                List<long> populationOfCities = cities.Values.ToList();
                long sum = populationOfCities.Sum();
                string countryName = country.ToString();
                countryPopulation[countryName] = sum;
                cities = cities.OrderByDescending(city => city.Value).ToDictionary(t => t.Key, t => t.Value);
                countries[country][0] = cities;
            }

            countries = countries.OrderByDescending(country => country.Value[1][country.Key]).ToDictionary(t => t.Key, t=>t.Value);

            foreach (var country in countries)
            {
                Dictionary<string,long> cities = country.Value[0];
                long totalPopulation = country.Value[1][country.Key];
                Console.WriteLine($"{country.Key} (total population: {totalPopulation})");
                foreach (var city in cities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

            Console.WriteLine();
        }
    }
}
