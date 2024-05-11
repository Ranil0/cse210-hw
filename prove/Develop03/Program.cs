using System;

namespace ScriptureMemorizer
{
    class Program
    {
        
        static void Main()
        {
            Scripture scripture = new Scripture("2 Nephi ", 22, 2, "Behold, God is my salvation; I will trust, and not be afraid; for the Lord JEHOVAH is my strength and my song; he also has become my salvation. ");
            Console.Clear();
            scripture.Display(); 
            Console.Write("\nPress Enter to continue or type 'quit' to exit. ");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nCongratulations, you have memorized this scripture!\n");
                    break;
                }
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
}