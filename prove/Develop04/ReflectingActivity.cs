public class ReflectingActivity : Activity
{
    private string[] _reflectionPrompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?",
        "What are some attributes that you admire in others?",
        "When was the last time you felt a deep sense of gratitude?",
    };

    public ReflectingActivity(int duration) : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.", duration) { 
    }
    protected override void ShowPrompt(int index)
    {
        Random random = new Random();
        int randomIndex = random.Next(_reflectionPrompts.Length);
        Console.WriteLine(_reflectionPrompts[randomIndex]);
        ShowAnimation();
        Thread.Sleep(1000);
    }
}