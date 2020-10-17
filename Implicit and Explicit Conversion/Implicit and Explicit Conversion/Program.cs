using System;

namespace Implicit_and_Explicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            int num = 346265;
            long bigNum = num;

            float myFloat = 12.34f;
            double myNewDouble = myFloat;

            double myDouble = 13.75;
            int myInt;
            // Explicit Converstion
            // cast double to int;
            myInt = (int)myDouble;

            // typeConversion
            string myString = myDouble.ToString();
            string stringFloat = myFloat.ToString();
            bool sunIsShining = true;
            sunIsShining.ToString();
            Console.WriteLine($"{myString} {stringFloat} Is sun shining: {sunIsShining}");
            Console.ReadLine();
        }
    }
}
