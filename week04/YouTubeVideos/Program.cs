using System;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video("Minecraft", "Fernando Añaña", 1235);
        Console.WriteLine(video.GetVideoDetails());
        video.DisplayVideoAndComments();
    }
}