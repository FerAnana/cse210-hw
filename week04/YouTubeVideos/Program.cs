using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Minecraft", "CubePlayer", 1200);
        Video video2 = new Video("My opinion about meat", "Fernando Añaña", 420);
        Video video3 = new Video("Make up tutorial", "Sofia Nievas", 720);
        Video video4 = new Video("We won!!", "Striker09", 1920);
        Video video5 = new Video("Chess drama", "GMSergio", 1620);

        video1.DisplayVideoAndComments();
        video2.DisplayVideoAndComments();
        video3.DisplayVideoAndComments();
        video4.DisplayVideoAndComments();
        video5.DisplayVideoAndComments();
    }
}