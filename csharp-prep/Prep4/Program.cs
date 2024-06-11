using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNum = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNum != 0)
        {
           Console.Write("Enter number: ");
           string userInput = Console.ReadLine();
           userNum = int.Parse(userInput);

           if (userNum != 0)
           {
                numbers.Add(userNum);   
           }
        }

        // Step 1: Compute the sum or total 
        int total = 0;
        foreach (int number in numbers)
        {
            total = total + number;
        }

        Console.WriteLine($"The sum is: {total}");

        // Step 2: Compute the average
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        int maxNum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNum)
            {
                // if this number is greater than the max, we have found the new max!
                maxNum = number;
            }
        }

        Console.WriteLine($"The largest number is: {maxNum}");
    }
}