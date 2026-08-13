public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string userInput = "";

        while (userInput != "6")
        {   
            DisplayPlayerInfo();

            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goal");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine().Trim();

            if (userInput == "1")
            {
                CreateGoal();
            }
            else if (userInput == "2")
            {
                ListGoalDetails();
            }
            else if (userInput == "3")
            {
                SaveGoals();
            }
            else if (userInput == "4")
            {
                LoadGoals();
            }
            else if (userInput == "5")
            {
                RecordEvent();
            }
            else if (userInput == "6")
            {
                Console.WriteLine("Thank you so much for your participation! Good luck achieving your goals!");
            }
            else
            {
                Console.WriteLine("Ops! Invalid option... please try again.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points. Level: {GetPlayerLevel()}");
        Console.WriteLine();
    }

    private string GetPlayerLevel()
    {
        if (_score >= 1500)
        {
            return "Expert";
        }
        else if (_score >= 500)
        {
            return "Apprentice";
        }
        else
        {
            return "Novice";
        }
    }

    public void ListGoalNames()
    {
        int count = 1;

        foreach (Goal goal in _goals)
        {   
            Console.WriteLine($"{count}. {goal.GetShortName()}");
            count++;
        }
    }

    public void ListGoalDetails()
    {
        int count = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
        }
    }

    public void CreateGoal()
    {   
        Console.WriteLine();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine();

        Console.Write("Which type of goal would you like to create? ");
        string userInput = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        Goal goal;
        if (userInput == "1")
        {
            goal = new SimpleGoal(goalName, goalDescription, goalPoints);
        }
        else if (userInput == "2")
        {
            goal = new EternalGoal(goalName, goalDescription, goalPoints);
        }
        else if (userInput == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            goal = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
        }
        else
        {
            Console.WriteLine("Ops! Invalid option... please try again");
            return;
        }
        
        _goals.Add(goal);

        Console.WriteLine();
        Console.WriteLine("Your goal was created!");


    }

    public void RecordEvent()
    {   
        Console.WriteLine("The goals are:");
        Console.WriteLine();
        ListGoalNames();
        Console.WriteLine();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()); 

        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Sorry invalid option.");
            return;
        }

        int points = _goals[choice -1 ].RecordEvent();

        _score += points;

        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {_score}.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Your goals were saved!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

         
        for (int i = 1; i < lines.Length; i++)
        { 
            string[] parts = lines[i].Split(":");
            string[] details = parts[1].Split("|");

            Goal goal;

            if (parts[0] == "SimpleGoal")
            {
                goal = new SimpleGoal(details[0], details[1], int.Parse(details[2]), bool.Parse(details[3]));
            }
            else if (parts[0] == "EternalGoal")
            {
                goal = new EternalGoal(details[0], details[1], int.Parse(details[2]));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                goal = new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4]), int.Parse(details[5]));
            }
            else
            {
                Console.WriteLine("Sorry, invalid option! Please try again.");
                continue;
            }
            _goals.Add(goal);
        }
    }
}