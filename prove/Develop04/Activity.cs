using System;
using System.Threading;
using System.Collections.Generic;
public abstract class Activity
{
    protected int _duration;
    protected string _name;
    protected string _description;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void StartingActivity()
    {
        Console.WriteLine($"Prepare to begin {_name} activity: {_description}");
        Thread.Sleep(3000);
        for (int i = 1; i <= _duration; i++)
        {
            ShowPrompt(i);
        }
        EndActivity();
    }

    protected abstract void ShowPrompt(int index);
    private void EndActivity()
    {
        Console.WriteLine("You've done a great job!");
        Console.WriteLine($"You have completed the {_name} activity in {_duration} seconds.");
        Thread.Sleep(3000);
    }
    protected void ShowAnimation()
    {
        Console.Write("Loading");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
    }
}