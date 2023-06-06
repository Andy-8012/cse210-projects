using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        string first_name;
        string last_name;

        Console.WriteLine("What is your first name? ");
        first_name = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        last_name = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");

    }
}