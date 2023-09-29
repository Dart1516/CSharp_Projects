using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Scripture s1 = new Scripture();
        string reference = s1.getReference();
        string originalScriptureText = s1.getScriptureText();
        Word w1 = new Word(originalScriptureText);
        string modifiedText = w1.getModifiedText();
        Console.WriteLine("Well come to the Scripture Mastery Passages. ");
        Console.WriteLine($"Today we will memorize this scripture: \n{reference}");
        Console.WriteLine($"{originalScriptureText}");
        Console.WriteLine("");
        string IsCompletelyHidden = s1.getIsCompletelyHidden();
        do
        {   
            Console.WriteLine("Press Enter twice to hide some words or write 'quit' to finish");
            string input = Console.ReadLine()!;
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Q)
            {
                break;
            }
            if(input.ToLower() == "quit")
            {
                break;
            }
            
            s1.HideRandomWords2();
            s1.GetDisplayText();
            Console.WriteLine($"");
        }while (IsCompletelyHidden == "no");

        Console.WriteLine("Thank you, see you next time!");
    }
}