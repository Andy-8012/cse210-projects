using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        string user_input;
        int grade_percent;
        string letter_grade;

        Console.WriteLine("What is your grade percentage? ");
        user_input = Console.ReadLine();

        grade_percent = int.Parse(user_input);

        if (grade_percent >= 90){
            letter_grade = "A";
        }
        else if (grade_percent >= 80){
            letter_grade = "B";
        }
        else if (grade_percent >= 70){
            letter_grade = "C";
        }
        else if (grade_percent >= 60){
            letter_grade = "D";
        }
        else{
            letter_grade = "F";
        }

        if (grade_percent >= 70){
            Console.WriteLine("Congrats you passed!");
        }
        else{
            Console.WriteLine("Better luck next time!");
        }

        Console.WriteLine($"Your grade is a {letter_grade}");
    }
}