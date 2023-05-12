using System;
using System.IO;


public class PromptGenerator

{

    public List<string> _prompts;

    public void GeneratePrompt()
    {


        var random = new Random();
        string prompts = Random.Next(_prompts);

    }

    public void LoadPromptsFromFile()
    {
        Console.WriteLine("Select a Prompt:  ");

        string answer = Console.ReadLine();

        int counter = 0;
        string line;

        // read file & display each line
        System.IO.StreamReader file = new System.IO.StreamReader("../journal.txt");

        while ((line = file.ReadLine()) != null)
        {
            Console.WriteLine(line);
            counter++;
        }

        file.Close();

        Console.ReadLine();


    }

    public void AddPrompt()
    {
        Console.WriteLine("Would you like to add a prompt? ");
        string answer = Console.ReadLine();

        if (answer == "yes")
        {
            var addPrompt = new List<string>();

            Console.WriteLine("Add prompt: ");
            string newPrompt = Console.ReadLine();

            newPrompt.GeneratePrompt.Add();


        }
    }

    public void RemovePrompt()
    {

    }

}

