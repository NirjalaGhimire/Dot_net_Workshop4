namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();

            s1.name = "Nisha";
            s1.age = 24;
            s1.grade = 15;

            s2.name = "Khushi";
            s2.age = 25;
            s1.grade = 5;
 
            Console.WriteLine("----- Student 1 -------");
            Console.WriteLine("Name: " + s1.name);
            Console.WriteLine("age: " + s1.age);
            Console.WriteLine("grade: " + s1.grade);

            Console.WriteLine("----- Student 2 -------");
            Console.WriteLine("Name: " + s2.name);
            Console.WriteLine("Age: " + s2.age);
            Console.WriteLine("Course: " + s2.grade);

            Console.WriteLine("\nCollege Name: " + Student.collegeName);
        }
    }
}
