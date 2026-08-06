using System.Data;
using System.Reflection.Metadata;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!\n");
        Console.WriteLine($"{_description}\n");

        bool isValidDuration = false;

        while (!isValidDuration)
        {
            Console.Write($"How long in seconds, would you like for your session? ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int seconds) && seconds > 0)
            {
                _duration = seconds;
                isValidDuration = true;
            }
            else
            {
                Console.WriteLine("Ops! Invalid input... please try again.");
            }
        }
        
        Console.Clear();

        Console.Write("Get ready... ");
        ShowCountDown(5);        
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {   
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}!");    
        ShowSpinner(5);    
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}