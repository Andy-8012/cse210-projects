using System;

public class Entry
{

    public string _date;
    public string _promptText;
    public string _entryText;
    public string _dayRating;

    public void Display(){
        Console.WriteLine($"You rated this day a {_dayRating}/10");
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}