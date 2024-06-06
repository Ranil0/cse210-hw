using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exerciseList = new List<Exercise>();
        
        Running running = new Running("June 06, 2024", 30, 3.5);
        exerciseList.Add(running);

        StationaryBiking stationaryBiking = new StationaryBiking("June 08, 2024", 60, 10);
        exerciseList.Add(stationaryBiking);

        Swimming swimming = new Swimming("June 10, 2024", 20, 10);
        exerciseList.Add(swimming);
        
        Console.WriteLine();
        Console.WriteLine("Summary of Exercises:");
        Console.WriteLine();

        foreach (Exercise exercise in exerciseList) 
        {
            Console.WriteLine(exercise.GetSummary());
			
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}   