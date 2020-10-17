using System;

namespace ParsingStringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            // parse strings to integer
            string myString = "245";
            string myStringTwo = "123";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(myStringTwo);

            int resultInt = num1 + num2;

            Console.WriteLine(resultInt);
            Console.ReadLine();
        }
    }
}
