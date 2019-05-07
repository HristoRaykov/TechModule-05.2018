using System;

namespace _05._Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lenth = int.Parse(Console.ReadLine());

            string[] array = input.Trim().Split(' ');

            bool[] isSameLength = new bool[array.Length];
            int ingredientsNumber = 0;
            string ingredients = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == lenth)
                {
                    ingredientsNumber++;
                    Console.WriteLine($"Adding {array[i]}.");
                    ingredients += array[i] + ", ";
                    isSameLength[i] = true;

                    if (ingredientsNumber == 10)
                    {
                        break;
                    }
                }
            }
            ingredients = ingredients.Remove(ingredients.Length-2);
            Console.WriteLine($"Made pizza with total of {ingredientsNumber} ingredients.\n" +
                $"The ingredients are: {ingredients}.");
        }
    }
}
