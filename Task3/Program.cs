using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object of ParameterDemo
            ParameterDemo demo = new ParameterDemo();

            // 1. Call Increase(ref int)
            int value = 20;
            demo.Increase(ref value);
            Console.WriteLine("Value after Increase: " + value);

            // 2. Call GetFullName(out string)
            string fullName;
            demo.GetFullName(out fullName);
            Console.WriteLine("Full Name: " + fullName);

            // 3. Call SumAll(params int[])
            int total = demo.SumAll(10, 20, 30, 40);
            Console.WriteLine("Sum of all numbers: " + total);

            Console.ReadLine(); // keeps window open (optional)
        }
    }
}
