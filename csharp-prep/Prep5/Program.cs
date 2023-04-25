using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string username = PromptUserName();
        int userNumber = PromptUserNumber();

        int sqNumber = SquareNumber(userNumber);

        DisplayResult(username, sqNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?  ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?  ");

        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is:  {square}");
    }

}