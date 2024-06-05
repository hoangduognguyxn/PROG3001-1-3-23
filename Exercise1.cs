using System;

class Excercise1
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double number))
        {
            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }

        }
        else
        {
            Console.WriteLine("Invalid number. Please enter a valid number!");
        }
    }
}