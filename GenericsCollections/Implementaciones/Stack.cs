using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> books = new Stack<string>();
        books.Push("Book 1");
        books.Push("Book 2");
        books.Push("Book 3");

        Console.WriteLine("Stack of books:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        // Pop (remove) the top item
        string lastBook = books.Pop();
        Console.WriteLine($"\nRemoved the last added book: {lastBook}");

        Console.WriteLine("\nStack after removing one book:");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }
    }
}
