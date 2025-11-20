using System;

public class Calculator
{
    // 1. Void method to print welcome message
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // 2. Method that adds two numbers and returns the result
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // 3. Method with optional parameter (default = 1) for multiplication
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}
