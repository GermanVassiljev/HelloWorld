using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asks the user to enter their  first name
            //programm greets the user using their first name
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Hello "+firstName+" "+ LastName+"!");
            //string interpolation
            
        }
    }
}
