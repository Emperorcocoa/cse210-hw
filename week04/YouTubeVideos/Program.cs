using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "Very helpful!"));
        video1.AddComment(new Comment("Bob", "Clear explanation."));
        video1.AddComment(new Comment("Charlie", "Loved the examples."));
        videos.Add(video1);

        Video video2 = new Video("Understanding OOP", "TechWorld", 840);
        video2.AddComment(new Comment("Diana", "This finally makes sense."));
        video2.AddComment(new Comment("Ethan", "Great visuals."));
        video2.AddComment(new Comment("Fiona", "Please make more videos like this."));
        videos.Add(video2);

        Video video3 = new Video("Abstraction Explained", "DevSimplified", 720);
        video3.AddComment(new Comment("George", "Perfect timing for my class."));
        video3.AddComment(new Comment("Hannah", "Simple and clear."));
        video3.AddComment(new Comment("Ian", "Best explanation so far."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetDisplayText()}");
            }

            Console.WriteLine();
        }
    }
}
