using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // vids...
        Video video1 = new Video("Introduction to C#", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing!"));

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 600);
        video2.AddComment(new Comment("Dave", "Amazing content!"));
        video2.AddComment(new Comment("Eve", "Loved it."));

        Video video3 = new Video("C# Design Patterns", "Chris Johnson", 450);
        video3.AddComment(new Comment("Frank", "Well explained."));
        video3.AddComment(new Comment("Grace", "Very helpful, thanks!"));
        video3.AddComment(new Comment("Hannah", "I learned a lot."));

        // List...
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate...
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}