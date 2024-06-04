using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Create videos...
        Video video1 = new Video("Video 1", "Author 1", 300);
        Video video2 = new Video("Video 2", "Author 2", 600);
        Video video3 = new Video("Video 3", "Author 3", 900);

        // Comments...
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Very informative."));
        video1.AddComment(new Comment("User3", "Thanks for sharing."));

        video2.AddComment(new Comment("User1", "Amazing content!"));
        video2.AddComment(new Comment("User3", "Loved it."));
        video2.AddComment(new Comment("User4", "Keep it up!"));

        video3.AddComment(new Comment("User2", "Superb!"));
        video3.AddComment(new Comment("User3", "Excellent explanation."));
        video3.AddComment(new Comment("User5", "Very helpful."));

        // Create list...
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Show details...
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}