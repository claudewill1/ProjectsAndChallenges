using System;

namespace Introduction_to_Methods
{
    /*A method is a code block that contains a series of statements. A program causes the statements
     * to be executed by calling the method and specifying any required method arguments. In C#,
     * every executed instruction is performed in the context of a method. The Main method is the entry point for every C#
     * application and it is called by the common language runtime (CLR) when the program is started.
     * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods */

    /*Method Syntax
     * <Access Specifier><Return Type><Method Name>(Parameter List)
     * {
     *      Method Body
     * }
     * */
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("A quick brown fox jumped over the fence.");
            Console.ReadLine();
        }
        // access modifier (static) return type method name (parameter1, parameter2)
        // whenever you want to call a method within a static method
        // you have to make the other method static as well
        // Keep methods simple
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
            
        }
        public static void WriteSomethingSpecific(string aMessage)
        {
            Console.WriteLine(aMessage);
            
        }
    }
}
