using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Substring(int32) is used to get the Substring from the string, starting from the specified index.
             * ToLower() is used to convert the string to lowercase.
             * ToUpper() is used to convert the string to uppercase.
             * Trim() is used to trim all leading and trailing white space from the string. */
            string aString = "ABCD";
            Console.WriteLine(aString.Substring(1, 3));

            Console.ReadLine();

        }
    }
}
