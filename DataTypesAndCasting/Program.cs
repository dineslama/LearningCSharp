using System;

namespace DataTypesAndCasting

{
    public class Program
    {
        public static void Main()
        {
            //implicit casting
            int a = 'A';
            Console.WriteLine(a);
            int i = 1245;
            long c = i;
            long l = 'B';
            Console.WriteLine(l);
            double d = 12.25f;
            Console.WriteLine(d);
            //explicit casting
            double num1 = 75.25;
            int num2 = (int)num1;
            char char1 = (char)num1;

            int num3 = 100;
            string str = num3.ToString();
            int num4 = int.Parse("123");

            byte thisIsByte = 1;
            Console.WriteLine("byte: " + thisIsByte);
            sbyte thisIsSignedByte = -1;
            Console.WriteLine("sbyte: " + thisIsSignedByte);
            short thisIsShort = -2;
            Console.WriteLine("short: " + thisIsShort);
            ushort thisIsUnsignedShort = 2;
            Console.WriteLine("ushort: " + thisIsUnsignedShort);
            int thisIsInt = -4;
            Console.WriteLine("int: " + thisIsInt);
            uint thisIsUnsignedInt = 4;
            Console.WriteLine("uint: " + thisIsUnsignedInt);
            float thisIsFloat = 8;
            Console.WriteLine("float: " + thisIsFloat);
            double thisIsDouble = 10.5;
            Console.WriteLine("double: " + thisIsDouble);
            long thisIsLong = -123456;
            Console.WriteLine("long: " + thisIsLong);
            ulong thisIsUnsignedlong = 123456;
            Console.WriteLine("ulong: " + thisIsUnsignedlong);
            bool thisIsBool = true;
            Console.WriteLine("bool: " + thisIsBool);
            char thisIsChar = 'c';
            Console.WriteLine("char: " + thisIsChar);
            string thisIsString = "string";
            Console.WriteLine("string: " + thisIsString);
            object thisIsObject = new object();
            Console.WriteLine("object: " + thisIsObject);
            DateTime thisIsDateTime = new DateTime();
            Console.WriteLine("DateTime: " + thisIsDateTime);
            decimal thisIsDecimal = 1234567890;
            Console.WriteLine("decimal: " + thisIsDecimal);

            //implicit conversion
            thisIsShort = thisIsByte;
            thisIsShort = thisIsSignedByte;
            thisIsUnsignedShort = thisIsByte;
            thisIsUnsignedShort = thisIsChar;
            thisIsInt = thisIsByte;
            thisIsInt = thisIsSignedByte;
            thisIsInt = thisIsChar;
            thisIsInt = thisIsShort;
            thisIsInt = thisIsUnsignedShort;
            thisIsUnsignedInt = thisIsByte;
            thisIsUnsignedInt = thisIsChar;
            thisIsUnsignedInt = thisIsUnsignedShort;
            thisIsFloat = thisIsByte;
            thisIsFloat = thisIsSignedByte;
            thisIsFloat = thisIsShort;
            thisIsFloat = thisIsUnsignedShort;
            thisIsFloat = thisIsChar;
            thisIsFloat = thisIsInt;
            thisIsFloat = thisIsUnsignedInt;
            thisIsDouble = thisIsByte;
            thisIsDouble = thisIsSignedByte;
            thisIsDouble = thisIsShort;
            thisIsDouble = thisIsUnsignedShort;
            thisIsDouble = thisIsChar;
            thisIsDouble = thisIsInt;
            thisIsDouble = thisIsUnsignedInt;
            thisIsDouble = thisIsFloat;
            thisIsLong = thisIsByte;
            thisIsLong = thisIsSignedByte;
            thisIsLong = thisIsShort;
            thisIsLong = thisIsUnsignedShort;
            thisIsLong = thisIsChar;
            thisIsLong = thisIsInt;
            thisIsLong = thisIsUnsignedInt;
            thisIsUnsignedlong = thisIsByte;
            thisIsUnsignedlong = thisIsUnsignedShort;
            thisIsUnsignedlong = thisIsChar;
            thisIsUnsignedlong = thisIsUnsignedInt;

            //explicit conversion
            thisIsFloat = (float)thisIsDouble;
            Console.WriteLine("float: " + thisIsFloat);

            string str1 = i.ToString();
            object o = str1;
            o = i;
            //o = f;
            o = l;
        }
    }

    namespace test
    {
        public class Program
        {
        }
    }
}