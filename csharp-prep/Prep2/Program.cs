using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float grade = float.Parse(userInput);

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Grade Received: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else
        {
            Console.WriteLine("Keep your notes and study your weak areas. You are sure to pass next time!");
        }

    }
}