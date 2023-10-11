// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Ask the user for an integer between 1 and 100 inclusive
        Console.Write("Enter an integer between 1 and 100 inclusive: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 1 && number <= 100)
            {
                // Check and display the associated result based on user input
                if (number % 2 == 1 && number < 60)
                {
                    Console.WriteLine($"{number} - Odd and less than 60.");
                }
                else if (number % 2 == 0 && number >= 2 && number <= 24)
                {
                    Console.WriteLine("Even and less than 25.");
                }
                else if (number % 2 == 0 && number >= 26 && number <= 60)
                {
                    Console.WriteLine("Even and between 26 and 60 inclusive.");
                }
                else if (number % 2 == 0 && number > 60)
                {
                    Console.WriteLine($"{number} - Even and greater than 60.");
                }
                else if (number % 2 == 1 && number > 60)
                {
                    Console.WriteLine($"{number} - Odd and greater than 60.");
                }
            }
            else
            {
                Console.WriteLine("The entered integer is not within the valid range.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}

