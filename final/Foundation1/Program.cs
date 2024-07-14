using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();


        Video _video1 = new Video("Extreme Sports", "Jacob Marley", 180);
        _video1.AddComment("Biker54", "Ouch! Get well soon!");
        _video1.AddComment("fr33climb", "And that's why we wear a helmet.");
        _video1.AddComment("Newbie", "I don't think I'll be doing that anytime soon...");

        Video _video2 = new Video("Monkeys with typewriters", "Will Shakespeare", 300);
        _video2.AddComment("Fledgling34", "No freaken way. It's gotta be fake.");
        _video2.AddComment("PokeF4n", "I'm sure it could happen. most writers are lazy anyways.");
        _video2.AddComment("A4U", "That monkey's putting modern authors to shame.");

        Video _video3 = new Video("My shadow's a jerk.", "Quincy Peterson", 240);
        _video3.AddComment("B3li3Ver", "You know that's probably a demon.");
        _video3.AddComment("Shadow", "Ignore B3li3Ver, get some sleep.");

        _videos.Add(_video1);
        _videos.Add(_video2);
        _videos.Add(_video3);


        foreach (var video in _videos)
        {
            video.PrintVideoInfo();
        }
    }
}