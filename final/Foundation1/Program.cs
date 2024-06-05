using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        //Video1
        Video videoYoutube1 = new Video("10 Most Mezmerizing Places in the Philippines: Finding a Place in the Pearl of the Orient!", "Virgie B. Gerez", 912);

        Comment videoYoutube1C1 = new Comment("Steven", "This video is really informative, and makes me interested to explore the Philippnes soon!");
        Comment videoYoutube1C2 = new Comment("Joel", "Thank you for making this beautiful content that truly captivating.");
        Comment videoYoutube1C3 = new Comment("Manilyn", "Wow! Amazing place to explore soon.");

        videoYoutube1.ListComment(videoYoutube1C1);
        videoYoutube1.ListComment(videoYoutube1C2);
        videoYoutube1.ListComment(videoYoutube1C3);

        videosList.Add(videoYoutube1);

        //Video2
        Video videoYoutube2 = new Video("Palawan: A Truly Paradise!", "Antonio Bancairen", 899);

        Comment videoYoutube2C1 = new Comment("Romeo", "I did not know that there is a such place on earth like this. Thank you for providing directions, and possible budget to spend.");
        Comment videoYoutube2C2 = new Comment("Tessie", "I haven't been to any paradise places in my life, but you have given me ideas to consider in terms of budget-wise, and practicality to experience a kind of paradise.");
        Comment videoYoutube2C3 = new Comment("Anne", "What a beautiful place it is! I would love to visit soon.");

        videoYoutube2.ListComment(videoYoutube2C1);
        videoYoutube2.ListComment(videoYoutube2C2);
        videoYoutube2.ListComment(videoYoutube2C3);

        videosList.Add(videoYoutube2);

        //Video3
        Video videoYoutube3 = new Video("Pinoy Delicacies: A Mouth Watering Experince", "Crez Anne Labuyo", 752);

        Comment videoYoutube3C1 = new Comment("Kim", "I love it, hoping to visit again next month, and taste again the delicious food that the country can offer.");
        Comment videoYoutube3C2 = new Comment("Jared", "You are captivating me on how you presented your contents, and the deffirent flavors you mentioned.");
        Comment videoYoutube3C3 = new Comment("Fernando", "I think, these delicacies are so delicious, and wothy to try it.");

        videoYoutube3.ListComment(videoYoutube3C1);
        videoYoutube3.ListComment(videoYoutube3C2);
        videoYoutube3.ListComment(videoYoutube3C3);

        videosList.Add(videoYoutube3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}