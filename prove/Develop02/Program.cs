using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Entry entry = new Entry();
        Console.WriteLine("Please select one of the selections below  ");
        entry._prompt = "1. Write \n2. Display \n3. Load \n4. Save\n5. Quit";
        Console.WriteLine("Please enter your selection: ");
        Console.ReadLine();
        int answer = 0;


        while (answer != 5)
        {

            answer = Selection();

            switch (answer)
            {
                case 1:
                    string menuNum = DisplayMenu();

            }

        }


    }
}