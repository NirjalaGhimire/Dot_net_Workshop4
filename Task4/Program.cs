using System;

class Program
{
    static void Main(string[] args)
    {
        // Create object using default constructor
        Player p1 = new Player();
        p1.playerName = "Unknown";
        p1.level = 0;
        p1.health = 0;

        // Create object using parameterized constructor
        Player p2 = new Player("Nirjala", 5, 100);

        // Print values for p1
        Console.WriteLine("\n--- Player 1 (Default Constructor) ---");
        Console.WriteLine("Name: " + p1.playerName);
        Console.WriteLine("Level: " + p1.level);
        Console.WriteLine("Health: " + p1.health);

        // Print values for p2
        Console.WriteLine("\n--- Player 2 (Parameterized Constructor) ---");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);
    }
}
