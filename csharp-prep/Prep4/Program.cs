using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int user_int = -1;
        int sum = 0;
        int average;
        int largest_number = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (user_int != 0){

            Console.WriteLine("Enter number: ");
            user_int = int.Parse(Console.ReadLine());
            if (user_int != 0){
                numbers.Add(user_int);
            }
        }

        foreach (int number in numbers){
            sum = sum + number;
        }
        Console.WriteLine($"The sum is: {sum}");

        average = sum / numbers.Count();
        Console.WriteLine($"The average is: {average}");

        foreach(int number in numbers){
            if (largest_number < number){
                largest_number = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest_number}");
    }

}
