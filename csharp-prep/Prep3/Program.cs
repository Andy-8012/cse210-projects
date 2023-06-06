using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1,100);

        Console.WriteLine("What is your guess? ");
        int user_guess = int.Parse(Console.ReadLine());

        while (user_guess != magic_number){
            if (user_guess < magic_number){
                Console.WriteLine("Higher");
                user_guess = int.Parse(Console.ReadLine());
            }
            else{
                Console.WriteLine("Lower");
                user_guess = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("You guess it!");
    }
}