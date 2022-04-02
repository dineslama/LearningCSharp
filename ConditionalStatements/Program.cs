using System;

namespace Conditional_Statements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // If Condition
            Console.WriteLine("Enter a number from 1 to 7");
            var day = Convert.ToInt16(Console.ReadLine());

            if (day == 1)
                Console.WriteLine("Sunday");
            else if (day == 2)
                Console.WriteLine("Monday");
            else if (day == 3)
                Console.WriteLine("Tuesday");
            else if (day == 4)
                Console.WriteLine("Wednesday");
            else if (day == 5)
                Console.WriteLine("Thursday");
            else if (day == 6)
                Console.WriteLine("Friday");
            else if (day == 7)
                Console.WriteLine("Saturday");
            else
                Console.WriteLine("Invalid Number Entered.");

            //switch condition
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;

                case 2:
                    Console.WriteLine("Monday");
                    break;

                case 3:
                    Console.WriteLine("Tuesday");
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    break;

                case 5:
                    Console.WriteLine("Thursday");
                    break;

                case 6:
                    Console.WriteLine("Friday");
                    break;

                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:

                    Console.WriteLine("Invalid Number Entered.");
                    break;
            }

            //ternary operator
            //ternary operator for odd and even number
            Console.WriteLine("Enter a number:");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "It is a even number" : "It is a Odd number");

            var IsEven = number % 2 == 0 ? true : false;
            //if else to print output
            if (IsEven == true)
                Console.WriteLine("The number is even number");
            else
                Console.WriteLine("The number is odd number");
            //ternary operator to print output
            Console.WriteLine(IsEven == true ? "The number is even number" : "The number is odd number");
        }
    }
}