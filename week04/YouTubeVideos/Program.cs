using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //create list 
        List<Video> videos = new List<Video>();

        //video1
        Video video1 = new Video("Learning C#", "John Oliveira", 600);
        video1.AddComment("Mary", "Great video!");
        video1.AddComment("Charles", "Very helpful, thanks!");
        video1.AddComment("Anna", "Could you explain more about classes?");
        videos.Add(video1);

        //video2
        Video video2 = new Video("Introduction to Unity", "Peter Silva", 1200);
        video2.AddComment("Lucas", "Awesome tutorial!");
        video2.AddComment("Fernanda", "I really liked the explanation.");
        video2.AddComment("Clara", "Please make more videos like this!");
        videos.Add(video2);

        //video3
        Video video3 = new Video("Databases with SQL", "Maria Santos", 900);
        video3.AddComment("Rafael", "Clear and objective explanation.");
        video3.AddComment("Paula", "I already shared this with my friends!");
        video3.AddComment("Tom", "Looking forward to part 2.");
        videos.Add(video3);

        //display all videos
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}


