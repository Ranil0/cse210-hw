using System;

class Program
{
    static void Main(string[] args)
    {
        var choice = ""; 
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            choice = Console.ReadLine();
            if (choice == "1")
            {

            } 
            else if (choice == "2")
            {
            
            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again");
            }
            while (choice != "4");
            
        }
    }
}