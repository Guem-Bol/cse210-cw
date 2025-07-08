using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int guess = 0;

        while (guess != number)
        {
            Console.WriteLine("What is your Guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");

            }
        }
    }
}