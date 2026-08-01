/* 
Author: Maylee Portales Picazo
Enhancement: a scripture library were added in the separate class, randomly selecting one scripture at each execution. A separate class was choose so that the Program class 
would not have to worry about how the scriptures are stored and even how the random draw works.
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        Scripture scripture = scriptureLibrary.GetRandomScripture();
        int wordsToHide = 3;        
        string userInput = ""; // Empty string (for the case when the user press enter).

        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("*** Press enter to continue or 'quit' to finish ***: ");
            userInput = Console.ReadLine().Trim().ToLower();

            if(userInput != "quit")
            {   
                scripture.HideRandomWords(wordsToHide);
            }            

        } while(!scripture.IsCompletelyHidden() && userInput != "quit");

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}