using System;

class Program
{
    static void Main(string[] args)
    {
        //Create videos
        Video video1 = new Video("Introduction to C#", "John Doe", 600);
        Video video2 = new Video("Advanced C# Programming", "Jane Smith", 1200);
        Video video3 = new Video("C# Design Patterns", "Jim Brown", 900);
        
        //Add comments to video1
        video1.AddComment(new Comment("Alice", "Great introduction!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot."));
        
        //Add comments to video2
        video2.AddComment(new Comment("Dave", "This was a bit advanced for me."));
        video2.AddComment(new Comment("Eve", "Excellent content!"));
        video2.AddComment(new Comment("Frank", "Could you cover more on delegates?"));
        
        //Add comments to video3
        video3.AddComment(new Comment("Grace", "Love the examples."));
        video3.AddComment(new Comment("Heidi", "Design patterns are so useful."));
        video3.AddComment(new Comment("Ivan", "Clear and concise."));
        
        //Putting the videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };
        
        //Iterate through the list of videos and display the information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }
            
            Console.WriteLine(); //Making sure to add an empty line between videos.
        }
    
    }
}