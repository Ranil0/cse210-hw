using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("ADA University", "Baku", "Baku", "Azerbaijan");

        Lecture lecture = new Lecture("TriMedia:", "Explore, Capture, and Connect", "May 29, 2024", "4 PM", address, "ADAli Magazine Staff", 250);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("BYU Marriot Center", "Provo", "Utah", "USA");

        Reception reception = new Reception("BYU Devotionals", "Devotionals with Brad P. Owens", "June 11, 2024", "11:05 AM", addressR, "https://speeches.byu.edu");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("Old City", "Baku", "Baku", "Azerbaijan");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Exploring Baku", "The City of Fire", "June 29, 2024", "10 AM", addressOG, "sunny");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
        Console.ReadKey();
    }
}