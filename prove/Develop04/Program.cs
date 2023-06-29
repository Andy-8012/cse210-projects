using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        DisplayMenu(userInput);

    }

    static void DisplayMenu(string userInput){
        Console.Clear();
        Console.WriteLine("Menue Options");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");

        userInput = Console.ReadLine();

        if (userInput == "1"){
            string name = "Breathing Activity";
            string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
            BreathingActivity activity = new BreathingActivity(name, description);
            activity.Run();
            DisplayMenu(userInput);
        }

        else if (userInput == "2"){
            string name = "Reflecting Activity";
            string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you canuse it in other aspects of your life.";
            ReflectingActivity activity = new ReflectingActivity(name, description);
            activity.Run();
            DisplayMenu(userInput);
        }

        else if (userInput == "3"){
            string name = "Listing Activity";
            string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            ListingActivity activity = new ListingActivity(name, description);
            activity.Run();
            DisplayMenu(userInput);
        }

        else if (userInput == "4"){
            Console.WriteLine("Thank you");
        }

        else {
            DisplayMenu(userInput);
        }
    }
}