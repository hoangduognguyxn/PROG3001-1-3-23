using System;

internal class Program
{
    static void Main(string[] args)
    {
        int sum = 0;

        while (true)
        {
            Console.Write("Enter a number (or press Enter to stop): ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            int number = int.Parse(input);

            if (number > 0)
            {
                sum += number;
            }
            else
            {
                Console.WriteLine("Negative numbers are skipped.");
                continue;
            }
        }

        Console.WriteLine($"The sum of the positive numbers is: {sum}");
    }
}

