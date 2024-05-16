public class BreathingActivity : Activity {
  
    public BreathingActivity() {
        _name = "Breathing Activity";
        _description = "...";
    }

    public void Run() {
        DisplayStartingMessage();

        // DateTime startTime = DateTime.Now;
        // DateTime stopTime = startTime.AddSeconds(_duration);

        // do {

        // }
        // while (DateTime.Now < stopTime);
        // Have the user to breathe in for 5 seconds
        Console.WriteLine("Breathe in");
        ShowCountDown(5);
        // Have the user to breathe out for 5 seconds
        Console.WriteLine("Breathe out");
        ShowCountDown(5);
        // Repeat this for duration (loop)
        DisplayEndingMessage();

    }
}