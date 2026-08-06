/*
Author: Maylee Picazo
Enhancement: added a int.TryParse() in the DisplayStartingMessage() method from Activity class to validate the user input, if they entered a whole number or not, when they are asked to enter the desired seconds.
Enhancement 2: added a if/else in the Run() method from ListingActivity class to show the word "thing" in plural or singular according to the quantity of things that the user list.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        do
        {   
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine().Trim();

            Console.WriteLine();

            if (userInput == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (userInput == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (userInput == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Thank you so much for your participation! It was great seeing you!");
            }
            else
            {
                Console.WriteLine("Ops! Invalid option... please try again!");
            }     

            if (userInput != "4")
            {
                Console.Write("Press enter to continue: ");
                Console.ReadLine(); 
            }     

        } while (userInput != "4");
    }
}