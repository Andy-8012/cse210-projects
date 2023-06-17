using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.FillPrompts(promptGenerator._prompts);

        string userSelection = "";

        while (userSelection != "5") {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userSelection = Console.ReadLine();

            if (userSelection == "1"){
                Entry anEntry = new Entry();
                string prompt = promptGenerator.GetRandomPrompt();
                anEntry._date = DateTime.Now.ToString("M/d/yyyy");
                anEntry._promptText = prompt;

                Console.WriteLine(prompt);
                Console.Write("> ");
                anEntry._entryText = Console.ReadLine();

                //I added another value to put into the Entry object
                //This asks the user to rank their day from 1-10
                Console.WriteLine("On a scale to 1-10 how good has your day been? 1 being the worst - 10 being the best.");
                Console.Write("> ");
                anEntry._dayRating = Console.ReadLine();

                theJournal.AddEntry(anEntry);
            }
            else if (userSelection == "2"){
                theJournal.DisplayAll();
            }
            else if (userSelection == "3"){
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (userSelection == "4"){
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else if (userSelection == "5"){
                
            }
            else {
                Console.WriteLine("Please enter an option 1-5");
            }
        }

    }
}