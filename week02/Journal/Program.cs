/* 
Author: Maylee Picazo
Enhancement: Added a verification to check if the file really exists before load it, and asked to the user for a valid filename.
*/

using System;
using System.Formats.Asn1;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(promptText);
                string userAnswer = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry entry = new Entry(dateText, promptText, userAnswer);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                Console.Write("Please enter the filename: ");
                 
                string loadFilename = Console.ReadLine();                

                while(!File.Exists(loadFilename))
                {   
                    Console.WriteLine("Ops! This file does not exist! Please enter a valid filename: ");
                    loadFilename = Console.ReadLine();
                }

                journal.LoadFromFile(loadFilename);

            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.Write("Please enter the filename: ");

                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("It was nice seeing you! Bye!");
            }
            else
            {
                Console.WriteLine("Invalid option, try again.");
            }
        }
    }
}