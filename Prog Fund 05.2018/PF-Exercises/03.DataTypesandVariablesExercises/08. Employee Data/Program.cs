using System;

namespace _08._Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            int age = 27;
            char gender = 'f';
            long personalID = 8306112507;
            int employeeNumber = 27563571;

            Console.WriteLine($"First name: {firstName}\n" +
                $"Last name: {lastName}\n" +
                $"Age: {age}\n" +
                $"Gender: {gender}\n" +
                $"Personal ID: {personalID}\n" +
                $"Unique Employee number: {employeeNumber}");


        }
    }
}
