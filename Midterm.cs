using System;
namespace Program.File.MyClasses
{
    public class Midterm
    {
        public Midterm()
        {
            Console.WriteLine("1. Create a User");
            Console.WriteLine("2. Create a Comment");
            Console.WriteLine("3. Print a List of Users");
            Console.WriteLine("4. print a List of Comments");
            Console.WriteLine("5. Exit the program");

            Console.WriteLine("");
            Console.WriteLine("Please select a value");

            string response = Console.ReadLine();

            Console.WriteLine("your response is: " + response);
        }
    }
}
