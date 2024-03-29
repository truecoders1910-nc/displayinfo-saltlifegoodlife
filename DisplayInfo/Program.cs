﻿using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first and last name from user input
            
            Console.WriteLine("what is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            // Get their favorite number
            Console.WriteLine("What is your favorite number?");
            string favNumber = Console.ReadLine();
            int num;
            while (!int.TryParse(favNumber, out num))
            {
                Console.WriteLine("Please enter a valid number!!!");
                favNumber = Console.ReadLine();
            }
            
            // Get their favorite animal
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            // Once you have gotten all their info and stored it,
            // display it back to them.
            if (num < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your name is {firstName} {lastName}, your favorite number is {num} and your favorite animal is {favAnimal}!");
            }
            else if (num > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your name is {firstName} {lastName}, your favorite number is {num} and your favorite animal is {favAnimal}!");
            }
            else Console.WriteLine($"Your name is {firstName} {lastName}, your favorite number is {num} and your favorite animal is {favAnimal}!");

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.
        }
    }
}
