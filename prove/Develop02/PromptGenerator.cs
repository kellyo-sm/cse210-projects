using System;
using System.IO;


public class PromptGenerator

{

    public List<string> _prompts = new List<string>();

    public void GeneratePrompt()
    {
        Random random = new Random();
        string[] _prompts = {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "what was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What are some things I am grateful for today?",
                "Share a story from your family history...",
                "Talk about your favorite family traditions...",
                "Explain an instance where you saw the Lord's hand at work in your life today",
                "Share personal insights into your favorite quote or conference talk.",
                "Share your favorite scripture story and explain why you like it.",
                "Write about your perspective on a current event."
            };
    }

    public void LoadPromptsFromFile()
    {

    }

    public void AddPrompt()
    {

    }

    public void RemovePrompt()
    {

    }

}

