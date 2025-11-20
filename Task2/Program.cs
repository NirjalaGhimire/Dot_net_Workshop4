namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create object of Calculator
            Calculator calc = new Calculator();

            // Call methods
            calc.PrintWelcome();

            int sum = calc.Add(10, 20);
            int product1 = calc.Multiply(5, 3);
            int product2 = calc.Multiply(7); // uses default value 1

            // Print results
            Console.WriteLine("Addition: " + sum);
            Console.WriteLine("Multiplication (5 * 3): " + product1);
            Console.WriteLine("Multiplication (7 * default): " + product2);
            Console.ReadLine();

        }
    }
}
