using System;

namespace StringChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Application takes users name
            // prints first line with name in all Uppercase
            // second line prints in all lowercase
            // line three trims off any whitespace
            // line four prings a substring of the name
            // this is accomplished in one WriteLine using string interpolation and the '\n' escape sequence
            Console.Write("Please enter your name and press enter: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Uppercase : {name.ToUpper()}\nLowercase : {name.ToLower()}\nTrimmed Value : {name.Trim()}\nSubstring of Name : {name.Substring(4, 8)}");
            Console.ReadLine();

        }
    }
}
