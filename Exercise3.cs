using System;

class Exercise3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a positive integer: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 0) 
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"The factorial of {number} is {factorial}.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}