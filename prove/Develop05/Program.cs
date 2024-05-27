using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Eternal Goal Setting Quest App!\n");
        GoalManager goalManager = new();
        goalManager.Start();
    }
}