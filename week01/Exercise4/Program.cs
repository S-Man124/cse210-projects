
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;

        // Keep asking for numbers until the user enters 0
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            // Do not add 0 to the list
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Check whether any numbers were entered
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // CORE REQUIREMENT 1: Calculate the sum
        int sum = 0;

        foreach (int value in numbers)
        {
            sum += value;
        }

        // CORE REQUIREMENT 2: Calculate the average
        double average = (double)sum / numbers.Count;

        // CORE REQUIREMENT 3: Find the largest number
        int largest = numbers[0];

        foreach (int value in numbers)
        {
            if (value > largest)
            {
                largest = value;
            }
        }

        // Display the core results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        // STRETCH CHALLENGE 1: Find the smallest positive number
        int smallestPositive = int.MaxValue;

        foreach (int value in numbers)
        {
            if (value > 0 && value < smallestPositive)
            {
                smallestPositive = value;
            }
        }

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers.");
        }

        // STRETCH CHALLENGE 2: Sort the numbers
        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (int value in numbers)
        {
            Console.WriteLine(value);
        }
    }
}
