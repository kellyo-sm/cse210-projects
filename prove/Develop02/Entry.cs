using System;
using System.IO;

public class Entry

{
    public string _prompt;
    private int _answer;
    private DateTime _date;


    public void DisplayEntry()
    {
        // int number = ;


        Console.WriteLine("What would you like to do today? ");
        Console.WriteLine($"{_prompt}");

        string _answer = Console.ReadLine();

        Console.WriteLine(DateTime.MaxValue);

        // Console.WriteLine($"{_answer}");
        // number = int.Parse(Console.ReadLine());


    }
}