class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1" || choice == "2" || choice == "3")
            {
                Console.Write("Enter the duration in seconds: ");
                if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
                {
                    if (choice == "1")
                    {
                        BreathingActivity breathingActivity = new BreathingActivity(duration);
                        breathingActivity.StartingActivity();
                    }
                    else if (choice == "2")
                    {
                        ReflectingActivity reflectingActivity = new ReflectingActivity(duration);
                        reflectingActivity.StartingActivity();
                    }
                    else
                    {
                        ListingActivity listingActivity = new ListingActivity(duration);
                        List<string> items = listingActivity.ListItems();
                        Console.WriteLine($"You listed {items.Count} items.");
                        listingActivity.StartingActivity();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid duration. Please enter a positive number.");
                    Thread.Sleep(2000);
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(2000);
            }
        }
    }
}