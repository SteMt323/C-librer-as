using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> colors = new HashSet<string>();
        colors.Add("Red");
        colors.Add("Blue");
        colors.Add("Green");
        colors.Add("Red");  // Duplicate, will not be added

        Console.WriteLine("HashSet of colors:");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }

        // Check if an element exists
        Console.WriteLine($"\nDoes HashSet contain 'Blue'? {colors.Contains("Blue")}");

        // Remove an item
        colors.Remove("Green");
        Console.WriteLine("\nAfter removing 'Green':");
        foreach (string color in colors)
        {
            Console.WriteLine(color);
        }
    }
}
