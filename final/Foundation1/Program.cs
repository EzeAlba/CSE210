using System;

class Program
{
    static void Main(string[] args)
    {

        // Create videos and add comments
        List<Video> videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 120),
            new Video("Video 2", "Author 2", 180),
            new Video("Video 3", "Author 3", 150)
        };

        videos[0].AddComment(new Comment("User 1", "Great video!"));
        videos[0].AddComment(new Comment("User 2", "Interesting content"));
        videos[1].AddComment(new Comment("User 3", "I learned a lot from this"));
        videos[2].AddComment(new Comment("User 4", "Could be better"));

        // Display video details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}
    
