using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Entry prompt1 = new Entry();
        prompt1._prompt = "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit".Replace("\n", Environment.NewLine);

        prompt1.DisplayEntry();

        int answer = -1;

        while (answer != 5)
        {
            // Console.Write("What would you like to do today?");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                PromptGenerator prompts2 = new PromptGenerator();
                prompts2._prompts GeneratePrompt();
                // GeneratePrompt(_prompts);
                string input = Console.ReadLine();

            }

            else if (answer == 2)
            {

            }
            else if (answer == 3)
            {

            }

            else if (answer == 4)
            {

            }
        }

    }
}