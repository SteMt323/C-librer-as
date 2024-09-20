using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> line = new Queue<string>();
        line.Enqueue("Person 1");
        line.Enqueue("Person 2");
        line.Enqueue("Person 3");

        Console.WriteLine("Queue:");
        foreach (string person in line)
        {
            Console.WriteLine(person);
        }

        // Dequeue (remove) an item
        string served = line.Dequeue();
        Console.WriteLine($"\n{served} has been served.");

        Console.WriteLine("\nQueue after serving one person:");
        foreach (string person in line)
        {
            Console.WriteLine(person);
        }
    }
}
