public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    private Random _random = new Random();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts.Add("-- Who are people that you appreciate? ");
        _prompts.Add("-- What are personal strength of yours? ");
        _prompts.Add("-- Who are people that you have helped this week? ");
        _prompts.Add("-- When have you felt the Holy Ghost this month? ");
        _prompts.Add("-- Who are some of your personal heroes? ");
    }

    public void Run()
    {
        
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");

        Console.WriteLine();
        GetRandomPrompt();

        Console.WriteLine();
        Console.Write("You may begin in... ");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine();
        List<string> listFromUser = GetListFromUser();
        _count = listFromUser.Count;

        Console.WriteLine();
        
        string word = "";
        if (_count == 1)
        {
            word = "thing";            
        }
        else
        {
            word = "things";            
        }
        Console.WriteLine($"You listed {_count} {word}!");
        Console.WriteLine();
        DisplayEndingMessage();

    }

    public void GetRandomPrompt()
    {
        int randomNumber = _random.Next(_prompts.Count);
        Console.WriteLine(_prompts[randomNumber]);
    }

    public List<string> GetListFromUser()
    {
        List<string> listFromUser = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {   
            Console.Write("> ");
            listFromUser.Add(Console.ReadLine());
        }

        return listFromUser;

    }
    
}