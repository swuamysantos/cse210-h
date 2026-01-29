using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "CodeMaster", 600);
        video1.AddComment(new Comment("Swuamy Santos", "Very helpful!"));
        video1.AddComment(new Comment("Jhon Legend", "Great explanation."));
        video1.AddComment(new Comment("Johanny Laurecne", "Loved it!"));

        Video video2 = new Video("How to winner in castle", "GameMaster", 900);
        video2.AddComment(new Comment("Yoshi", "Now I understand abstraction."));
        video2.AddComment(new Comment("Mario", "Clear and simple."));
        video2.AddComment(new Comment("Luigi", "Nice examples."));

        Video video3 = new Video("Cookies and Zombies", "CandyWorld", 1200);
        video3.AddComment(new Comment("Jhake", "Perfect this movies."));
        video3.AddComment(new Comment("Finn", "Thanks for this video."));
        video3.AddComment(new Comment("Princess Gumm", "Subbed!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
