using System;

namespace Constants
{
    /*Constants are immutable values which are known
     * at compilel time and do not change for the life of the program */
    class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const int days = 365, leapYearDays = 366;
        const string birthday = "04-09-1987";
        static void Main(string[] args)
        {
            Console.WriteLine($"My birthday is always going to be {birthday}");
            Console.ReadLine();
        }
    }
}
