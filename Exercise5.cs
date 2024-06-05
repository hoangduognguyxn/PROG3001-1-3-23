using System;

internal class Exercise5
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);

        int guess = 0;
        int attempts = 0;

        while (guess != secretNumber)
        {
            Console.Write("Guess a number between 1 and 100: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < secretNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the secret number {secretNumber} in {attempts} attempts.");
                break;
            }
        }
    }
}

