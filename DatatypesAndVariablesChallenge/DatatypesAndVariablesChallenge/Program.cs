using System;

namespace DatatypesAndVariablesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            byte aByte = 0;
            sbyte signedByte = 0;
            int anInteger = 123445;
            uint unsignedInteger = 4294967295;
            short aShort = 32467;
            ushort unsignedShort = 65535;
            long aLong = 9223372036854775807;
            ulong unsignedLong = (ulong)aLong * 2;
            float aFloat = -3.402823f;
            double aDouble = 12354123.23542;
            char aChar = '%';
            bool aBool = true;
            decimal aDecimal = 2347.23M;
            string string1 = "I control text";
            string numText = "123452345";
            int stringNum1 = Int32.Parse(numText);

            Console.WriteLine($"Byte : {aByte}\nsbyte : {signedByte}\ninteger : {anInteger}\nuint : {unsignedInteger}\nshort : {aShort}\n" +
                $"ushort : {unsignedShort}\nlong : {aLong}\nulong : {unsignedLong}\nfloat : {aFloat}\nbool : {aBool}\ndouble : {aDouble}\n" +
                $"char : {aChar}\ndecimal : {aDecimal}\nstring : {string1}\nstring parsed to integer : {stringNum1}");
            Console.ReadLine();

        }
    }
}
