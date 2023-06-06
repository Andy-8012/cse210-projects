using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square_number = SquareNumber(number);
        DisplayResult(name, square_number);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName(){
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.WriteLine("What is your favorite number? ");
        string string_number = Console.ReadLine();
        int number = int.Parse(string_number);
        return number;
    }

    static int SquareNumber(int number){
        int square_number = number * number;
        return square_number;
    }

    static void DisplayResult(string name, int number){
        Console.WriteLine($"{name}, the square of your number is {number}");
    }

    
}