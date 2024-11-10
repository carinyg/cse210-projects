using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float number;

        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = float.Parse(userInput);
            numbers.Add(number);
        } while (number != 0);

        float sum = 0;
        float highestNumber = 0;

        foreach (float item in numbers)
        {
            sum = sum + item;

            if (highestNumber < item)
            {
                highestNumber = item;
            }
        }

        float average = sum / (numbers.Count - 1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {highestNumber}");
    }
}