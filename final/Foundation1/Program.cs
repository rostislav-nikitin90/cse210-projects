using System;

namespace Foundation1;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._videoTitle = "5 Healthy Eating Tips";
        video1._author = "Allison Greene";
        video1._videoDuration = 300;

        Comment comment1Video1 = new Comment();
        comment1Video1._name = "John Lynch";
        comment1Video1._commentText = "Great video!";
        video1._comments.Add(comment1Video1);

        Comment comment2Video1 = new Comment();
        comment2Video1._name = "Suzanne O'Neill";
        comment2Video1._commentText = "I will definitely try this for my diet.";
        video1._comments.Add(comment2Video1);

        Comment comment3Video1 = new Comment();
        comment3Video1._name = "Alex Perry";
        comment3Video1._commentText = "Perfect! This is exactly what I need.";
        video1._comments.Add(comment3Video1);

        
        Video video2 = new Video();
        video2._videoTitle = "Top 10 Travel Destinations";
        video2._author = "Robert Biller";
        video2._videoDuration = 420;

        Comment comment1Video2 = new Comment();
        comment1Video2._name = "Jane Brown";
        comment1Video2._commentText = "Excellent destinations to visit!";
        video2._comments.Add(comment1Video2);

        Comment comment2Video2 = new Comment();
        comment2Video2._name = "Barbara Lange";
        comment2Video2._commentText = "Wow! I want to visit all these places!";
        video2._comments.Add(comment2Video2);

        Comment comment3Video2 = new Comment();
        comment3Video2._name = "Arnold Neumann";
        comment3Video2._commentText = "How wonderfully these attractive destinations are described and shown." +
                                      "\nThank you.";
        video2._comments.Add(comment3Video2);

        Comment comment4Video2 = new Comment();
        comment4Video2._name = "Leona Simpson";
        comment4Video2._commentText = "Yes, such places are worth visiting at least once in your life. Beautiful!";
        video2._comments.Add(comment4Video2);


        Video video3 = new Video();
        video3._videoTitle = "How to Write a Perfect Résumé";
        video3._author = "Anna Smith";
        video3._videoDuration = 600;

        Comment comment1Video3 = new Comment();
        comment1Video3._name = "Jessica Knightley";
        comment1Video3._commentText = "Great tips for writing a resume!";
        video3._comments.Add(comment1Video3);

        Comment comment2Video3 = new Comment();
        comment2Video3._name = "Thomas Taylor";
        comment2Video3._commentText = "Now I know exactly how to make my resume more attractive to employers.";
        video3._comments.Add(comment2Video3);

        Comment comment3Video3 = new Comment();
        comment3Video3._name = "Zoe Doron";
        comment3Video3._commentText = "This really helped me understand how to improve my resume.";
        video3._comments.Add(comment3Video3);


        Video videos = new Video();
        videos._videos.Add(video1);
        videos._videos.Add(video2);
        videos._videos.Add(video3);

        videos.DisplayAllVideos();
    }
}