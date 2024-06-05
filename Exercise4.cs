using System;

class Exercise4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            string rowInput = Console.ReadLine();

            Console.WriteLine("Enter the number of columns:");
            string columnInput = Console.ReadLine();

            if (int.TryParse(rowInput, out int rows) && int.TryParse(columnInput, out int columns))
            {
                if (rows > 0 && columns > 0)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter positive numbers for rows and columns.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for rows and columns.");
            }
        }
    }
