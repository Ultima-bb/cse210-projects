using System;

class Prompt
{   
    string[] _prompts = {
        "Overall, How was your day? ",
        "Did you talk to anyone New, or an old friend? ",
        "Anything significant happen today? ",
        "Any major life changing events in your friend's lives? ",
        "You haven't done anything crazy have you?"
    };

    public void getRandomPrompt()
    {   Random _generator = new Random();
        int _randomIndex = _generator.Next(0,5);
        string _randomPrompt = _prompts[_randomIndex]; 
        Console.WriteLine(_randomPrompt);       
    
    }
}