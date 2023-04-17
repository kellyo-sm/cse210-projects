using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?  ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name?  ");
        string lname = Console.ReadLine();

        Console.WriteLine($"Your name is {lname}, {fname} {lname}");


        //A >= 90
        //B >= 80
        //C >= 70
        //D >= 60
        //F < 60

        Console.Write("What is your grade percentage?  ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
            //Console.WriteLine("Your grade is an A");
        }
        else if (grade >= 80)
        {
            letter = "B";
            //Console.WriteLine("Your grade is a B");
        }
        else if (grade >= 70)
        {
            letter = "C";
            //Console.WriteLine("Your grade is a C");
        }
        else if (grade >= 60)
        {
            letter = "D";
            //Console.WriteLine("Your grade is a D");
        }
        else
        {
            letter = "F";
            //Console.WriteLine("Your grade is an F");

        }



        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed! :)");
        }
        else
        {
            Console.WriteLine("You failed :(  Better luck next time!");
        }
    }
}