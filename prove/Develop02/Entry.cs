using System;
using System.IO;

public class Entry

{


    public string _prompt;
    public string _answer;
    public DateTime _date;


    public void DisplayMenu()


    {
        string prompt = _prompt;
        string answer = _answer;
        int date = _date;

        console.writeLIne(DateTime.Now());
    }