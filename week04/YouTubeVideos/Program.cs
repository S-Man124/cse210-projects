
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1: Artificial Intelligence
        Video video1 = new Video(
            "Introduction to Artificial Intelligence",
            "Tech Learning Academy", 600);

        video1.AddComment(new Comment(
            "Sibusiso", "AI is transforming the future!"));
        video1.AddComment(new Comment(
            "James", "Very informative video."));
        video1.AddComment(new Comment(
            "Sarah", "I learned something new today."));

        videos.Add(video1);

        // Video 2: C# Programming
        Video video2 = new Video(
            "Learning C# Programming",
            "Code Academy", 900);

        video2.AddComment(new Comment(
            "Michael", "Great explanation of classes."));
        video2.AddComment(new Comment(
            "David", "This helped me understand C#."));
        video2.AddComment(new Comment(
            "Olwami", "Programming is interesting!"));

        videos.Add(video2);

        // Video 3: Cloud Computing
        Video video3 = new Video(
            "Cloud Computing Explained",
            "Cloud Technology Hub", 720);

        video3.AddComment(new Comment(
            "Peter", "Cloud computing is powerful."));
        video3.AddComment(new Comment(
            "Grace", "Excellent introduction."));
        video3.AddComment(new Comment(
            "John", "Looking forward to more videos."));

        videos.Add(video3);

        // Video 4: Python Programming
        Video video4 = new Video(
            "Building Software with Python",
            "Developer Academy", 840);

        video4.AddComment(new Comment(
            "Thabo", "Python is beginner friendly."));
        video4.AddComment(new Comment(
            "Nomsa", "I enjoyed this tutorial."));
        video4.AddComment(new Comment(
            "Alex", "Very useful programming tips."));

        videos.Add(video4);

        // Display all videos and comments
        Console.WriteLine("YOUTUBE VIDEO TRACKER");
        Console.WriteLine("=====================");

        foreach (Video video in videos)
        {
            Console.WriteLine();
            video.DisplayVideo();
            Console.WriteLine("------------------------------");
        }
    }
}
