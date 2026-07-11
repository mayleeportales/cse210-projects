using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(squaredNumber, userName);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;

        }

        static int SquareNumber(int number)
        {
            int square = number * number;

            return square;
        }

        static void DisplayResult(int square, string name)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }
    }
}