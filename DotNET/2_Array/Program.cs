using System;

namespace _2_Array;

class Logic
{
    static void Main()
    {
        // Array of integers
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Print the array
        Console.WriteLine("Array of integers:");
        foreach (var number in numbers)
        {
        Console.WriteLine(number);
        }

        // Array of strings
        string[] names = { "Alice", "Bob", "Charlie" };

        // Print the array
        Console.WriteLine("\nArray of strings:");
        foreach (var name in names)
        {
        Console.WriteLine(name);
        }
    }
}