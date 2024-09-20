using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(101, "John");
        students.Add(102, "Sarah");
        students.Add(103, "Mark");

        Console.WriteLine("Student dictionary:");
        foreach (KeyValuePair<int, string> student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }

        // Access by key
        Console.WriteLine($"\nStudent with ID 102: {students[102]}");

        // Remove an item
        students.Remove(101);
        Console.WriteLine("\nAfter removing student with ID 101:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }
    }
}
