using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number?  ");
        // string input1 = Console.ReadLine();

        Random randomNum = new Random();
        // int magic = int.Parse(input1);
        int magic = randomNum.Next(1, 11);


        int guess = -1;
        int guesses = 0;

        while (guess != magic)
        {
            guesses++;

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!!!");
                Console.WriteLine("Number of guesses: {0}", guesses);
                // Console.Write("Would you like to play again? (yes/no) ");
                // string answer = Console.ReadLine();

                // if (answer == "yes")
                // {
                //     return true;
                // }

                // if (answer == "no")
                // {
                //     return false;
                // }
            }
        }
    }
}