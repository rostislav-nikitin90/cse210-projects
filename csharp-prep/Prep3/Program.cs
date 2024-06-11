using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        int guessNum = -1;

        while (guessNum != magicNum)
        {
            Console.Write("What is your guess? ");
            string userGuessNum = Console.ReadLine();
            guessNum = int.Parse(userGuessNum);

            if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNum > magicNum)
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