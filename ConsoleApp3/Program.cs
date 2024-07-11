using System;
using System.ComponentModel.Design;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's ID
            Console.WriteLine("Enter your ID:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid input. Please enter a valid ID:");
            }

            // Get the user's name
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            // Get the user's age
            int age;
            do
            {
                Console.WriteLine("Enter your age:");
            } while (!int.TryParse(Console.ReadLine(), out age));

            // Print the data
            Console.WriteLine($"Your Data: ID = {id}, Name = {name}, Age = {age}");

            // Wait for the user to press a key before closing
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}