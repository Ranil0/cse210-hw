using System;

public class Entry 
{
    public string _date;
    public string _prompt;
    public string _response;

    public void GenerateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public void GeneratePrompt()
    {
        List<string> prompts = new List<string>()
        {
        "What new skill or knowledge did you acquire today, if any?",
        "Did you encounter any unexpected challenges today, and how did you handle them?",
        "How did I see the hand of the Lord in my life today?",
        "How did you prioritize your tasks or activities today, and did it align with your goals or values?",
        "Did you engage in any acts of kindness or generosity today, and how did it make you feel?",
        };

        Random rand = new Random();
        int randomIndex = rand.Next(prompts.Count);
        _prompt = prompts[randomIndex];
        Console.WriteLine(_prompt);
    }

    public void GetResponse()
    {
        Console.Write("> ");
        _response = Console.ReadLine();
    }
}