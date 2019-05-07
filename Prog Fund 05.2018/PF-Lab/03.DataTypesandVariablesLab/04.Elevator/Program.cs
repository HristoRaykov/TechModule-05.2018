using System;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity  = int.Parse(Console.ReadLine());

            int numberOfCourses;

            if (numberOfPeople % capacity > 0)
            {
                numberOfCourses = numberOfPeople / capacity + 1;
            }
            else
            {
                numberOfCourses = numberOfPeople / capacity;
            }
            Console.WriteLine(numberOfCourses);
        }
    }
}
