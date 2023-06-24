using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        string userInput = "";
        bool run = true;

        Reference reference = new Reference("Proverbs",3,5,6);
        Scripture scripture = new Scripture(reference,"Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct they paths.");

        Console.Write($"{reference.GetDisplayText()} ");
        Console.WriteLine(scripture.GetDisplayText());

        while(run){
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            if (userInput == ""){            
                scripture.HideRandomWords(3);
                Console.Clear();
                Console.Write($"{reference.GetDisplayText()} ");
                Console.WriteLine(scripture.GetDisplayText());
            
            }
            else if (userInput.ToLower() == "quit"){
                Console.WriteLine("Thanks for playing");
                run = false;
            }
            else {
                Console.Clear();
                Console.Write($"{reference.GetDisplayText()} ");
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Whoops you didn't enter an option.");
            }
            if(scripture.IsCompletelyHidden()){
                Console.WriteLine("Thanks for playing");
                run = false;
            }
        }

    }
}