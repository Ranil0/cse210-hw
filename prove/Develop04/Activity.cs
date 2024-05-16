public class Activity {

  protected string _name;
  protected string _description;
  protected int _duration;
  
  public Activity() {
      // Initialize _name, _description, and _duration
      _name = "";
      _description = "";
      _duration = 0;

  }

  public void DisplayStartingMessage() {
      //Console.Clear();
      Console.WriteLine($"Wecome to the {_name}");
      // Promp for the _duration
      ShowSpinner(5);
  }

  public void DisplayEndingMessage() {
      Console.WriteLine("Well done!!");
      ShowSpinner(5);
      //Console.Clear();
  }

  public void ShowSpinner(int seconds) {
      // Video
      Console.WriteLine("Spinner!");
  }

  public void ShowCountDown(int seconds) {
      for (int i=1; i<=seconds; i++) {
           Console.WriteLine(i);
           Thread.Sleep(1000);
      }
      Console.WriteLine("Countdown!");
  }
}