public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration) { 
        _name = "BreathingActivity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = duration;
    }

    protected override void ShowPrompt(int index)
    {
        if (index % 2 == 1)
            Console.WriteLine("Breathe in");
        else
            Console.WriteLine("Breathe out");
        ShowAnimation();
        Thread.Sleep(1000);
    }
}