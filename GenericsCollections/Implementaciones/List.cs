using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");

        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Remove an item
        fruits.Remove("Banana");
        Console.WriteLine("\nAfter removing 'Banana':");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Access by index
        Console.WriteLine($"\nFirst fruit: {fruits[0]}");
    }
}
