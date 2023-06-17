using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void FillPrompts(List<string> _prompts){
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What was your main goal for the day?");
        _prompts.Add("When did you wake up and how did you feel?");
    }
    
    public string GetRandomPrompt (){
        Random randomGenerator = new Random();
        int _promptsLength = _prompts.Count();
        int randomNumber = randomGenerator.Next(1,_promptsLength);
        string prompt = _prompts[randomNumber];
        return prompt;
    }
}