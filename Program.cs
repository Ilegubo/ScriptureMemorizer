using System;
using ScriptureMemorizer;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string text =
            "For behold, this is my work and my glory-to bring to pass the immortality and eternal life of man";
        Reference reference = new Reference("Moses", 1,39);
        Scripture scripture = new Scripture(reference,text);
        
        string userInput = "";
        while (!(userInput == "quit"))
        {
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine("\nPress Enter to continue, type quit to exit");
            scripture.HideRandomWords();
        }
        Console.WriteLine("Exiting...");
    }
}