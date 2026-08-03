using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    { 
        Video video1 = new Video("The Psychology Behind Procrastination", "Cintia Miranda", 90);
        Video video2 = new Video("How To Groom Your Dog at Home", "John Carpenter", 120);
        Video video3 = new Video("How To Make A Pumpkin Pie", "Sofia Johnson", 90);
        Video video4 = new Video("How To Make A Carrot Cake", "Catia Damasceno", 90);

        Comment comment1Video1 = new Comment("Gisele Barreto", "I have so many difficulties with procrastinating... this video helped me a lot!");
        video1.AddComment(comment1Video1);
        Comment comment2Video1 = new Comment("Haylee Figueiredo", "Thank you so much for the explanation, it was really helpful!");
        video1.AddComment(comment2Video1);
        Comment comment3Video1 = new Comment("John Ferrari", "I think that's one of the biggest problems that we face nowadays.");
        video1.AddComment(comment3Video1);
        Comment comment4Video1 = new Comment("Bruna Navarro", "Wow, I didn't know that procrastination doesn't mean being lazy!");
        video1.AddComment(comment4Video1);

        Comment comment1Video2 = new Comment("Jorge Ferraz", "I have a Shih Tzu. This video was really helpful.");
        video2.AddComment(comment1Video2);
        Comment comment2Video2 = new Comment("Maria Silva", "Thank you so much for sharing your knowledge! It will help me save money for sure.");
        video2.AddComment(comment2Video2);
        Comment comment3Video2 = new Comment("Joao Correia", "That's great!");
        video2.AddComment(comment3Video2);
        Comment comment4Video2 = new Comment("Veronica Trindade", "I will test it on my Yorkshire!");
        video2.AddComment(comment4Video2);

        Comment comment1Video3 = new Comment("Joseph Smith", "I will make it today!");
        video3.AddComment(comment1Video3);
        Comment comment2Video3 = new Comment("Angelica Garlic", "Yummy!!");
        video3.AddComment(comment2Video3);
        Comment comment3Video3 = new Comment("Anna Flores", "Finally I found this recipe!");
        video3.AddComment(comment3Video3);
        Comment comment4Video3 = new Comment("Beatriz Barbosa", "No way it's that easy!");
        video3.AddComment(comment4Video3);

        Comment comment1Video4 = new Comment("Anitta Cavalcante", "I love carrot cake!");
        video4.AddComment(comment1Video4);
        Comment comment2Video4 = new Comment("Matthew Wood", "I will make it for my wife!");
        video4.AddComment(comment2Video4);
        Comment comment3Video4 = new Comment("Maya Price", "I love how simply you teach.");
        video4.AddComment(comment3Video4);
        Comment comment4Video4 = new Comment("Isadora Fortes", "I'm Brazilian and we make carrot cake a different way, but the American carrot cake looks so delicious!");
        video4.AddComment(comment4Video4);
        
        List<Video> videoList = new List<Video>();
        videoList.Add(video1);
        videoList.Add(video2);
        videoList.Add(video3);
        videoList.Add(video4);

        foreach (Video video in videoList)
        {
            Console.WriteLine($"Video Title: {video.GetTitle()} by {video.GetAuthor()}");
            Console.WriteLine($"Video length in seconds: {video.GetLengthSeconds()}");
            Console.WriteLine($"Comments Quantity: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"Commenter: {comment.GetAuthorName()}");
                Console.WriteLine($"Comment: {comment.GetText()}");
            }

            Console.WriteLine();
        }

    }
}