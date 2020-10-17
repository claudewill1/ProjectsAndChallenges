using System;

namespace StringChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string here: ");
            // Read first user input and assign to variable
            string aString = Console.ReadLine();
            Console.Write("Enter a character to search: ");
            // Read the character input to search
            char aChar = Console.ReadLine()[0];
            // Get and display index of character in string
            int index = aString.IndexOf(aChar);
            Console.WriteLine($"Index of character {aChar} in the string is {index}");
            Console.Write("Enter you first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            string fullName = $"Your full name is {firstName} {lastName}";
            Console.WriteLine(fullName);

            Console.ReadLine();


        }
    }
}
