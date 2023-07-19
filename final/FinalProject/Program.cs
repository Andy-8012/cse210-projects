using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Gameplay gameplay = new Gameplay();

        gameplay.Start();

        Console.WriteLine("You died!");

        Console.WriteLine($"Your final score was {gameplay.GetScore()}");

    }
}