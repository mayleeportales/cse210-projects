using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        int wordsToHide = 3;
        
        string userInput = ""; // Empty string (for the case when the user press enter).
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.Write("Press enter to continue or 'quit' to finish: ");
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