using System;

class Prompt
{   
    string[] prompts = {
        "Overall, How was your day? ",
        "Did you talk to anyone New, or an old friend? ",
        "Anything significant happen today? ",
        "Any major life changing events in your friend's lives? ",
        "You haven't done anything crazy have you?"
    };

    public void getRandomPrompt()
    {   Random generator = new Random();
        int randomIndex = generator.Next(0,5);
        string randomPrompt = prompts[randomIndex]; 
        Console.WriteLine(randomPrompt);       
    
    }
}