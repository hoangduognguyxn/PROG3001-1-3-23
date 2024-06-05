using System;
using System.Diagnostics;

class Exercise2
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double dayNumber))
        {
            string dayName;
            switch(dayNumber)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day number. Please enter a valid number";
                    break;
            }
            Console.WriteLine(dayName);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number between 1 and 7.");
        }
    }
}