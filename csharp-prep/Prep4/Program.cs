using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userNum = -1;
        // int count = 0;

        while (userNum != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished:  ");

            string userInput = Console.ReadLine();
            userNum = int.Parse(userInput);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // double average = numbers.Average();
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int maxNum = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNum}");

    }
}