public class PromptGenerator
{
    private List<string> _prompts = new List<string>() {"How did I see the hands of the Lord today?", "What was the best experience I had today?", "Which memories came to my mind?", "What was the strongest emotion I felt today?", "What was the most relative thing I saw today?"};

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int randomIndex = random.Next(_prompts.Count);

        return _prompts[randomIndex];
    }
} 