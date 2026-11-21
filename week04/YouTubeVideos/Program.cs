using System;
using System.Collections.Generic;
 
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
 
        // video 1
        Video video1 = new Video("A Tribe Called Judah - Full Movie", "Funke Akindele", 8100);
        video1.AddComment(new Comment("Messiah", "This is one of my favorite movies!"));
        video1.AddComment(new Comment("Ibok", "The acting was so touching."));
        video1.AddComment(new Comment("Afai", "The plot twist at the end kept me on the edge of my seat!."));
        videos.Add(video1);
 
        // Video 2
        Video video2 = new Video("Creed III - Full Movie", "Keenan Coogler", 6960);
        video2.AddComment(new Comment("Sylvester", "The best action movie ever exist."));
        video2.AddComment(new Comment("Justice", "I so love this movie."));
        video2.AddComment(new Comment("David", "Best sports drama in years, thank you!."));
        videos.Add(video2);
 
        // Video 3
        Video video3 = new Video("The Woman King - Full Movie", "Dana Stevens", 8100);
        video3.AddComment(new Comment("Joana", "It's showed the strength of a woman."));
        video3.AddComment(new Comment("lucy", "The movie is legendary."));
        video3.AddComment(new Comment("elijah", "I have rewatched the movie at least five time very interesting"));
        videos.Add(video3);
 
        // Loop through the list of videos and display everything
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
 
    }
}