using System;

class Program
{
    static void Main(string[] args)
    {
        // -------------------- ENUM PART --------------------
        Console.Write("Enter a day: ");
        string day = Console.ReadLine().ToLower();

        DayType result;

        if (day == "friday" || day == "saturday")
        {
            result = DayType.Weekend;
        }
        else
        {
            result = DayType.Weekday;
        }

        Console.WriteLine("It is: " + result);


        // -------------------- RECORD PART --------------------
        Book b1 = new Book("C# Basics", "Nirjala Ghimire", 450.50);

        // Creating new object using 'with' expression, changing title and price
        Book b2 = b1 with { title = "Advanced C#", price = 999.99 };

        // Print first object
        Console.WriteLine("\nFirst Book Object:");
        Console.WriteLine($"Title: {b1.title}, Author: {b1.author}, Price: {b1.price}");

        // Deconstruct second object
        var (title, author, price) = b2;

        Console.WriteLine("\nSecond Book (Deconstructed):");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
        Console.ReadLine();
    }
}
