using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace I_claim_a_bit_of_tenderness
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        /**
         * Basic - 16)
         * 
         *  create a new string from a given string where the first and last characters will change their positions
         * **/
        public static void Basic_16_Arthurs()
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                string str;
                char firstChar, lastChar;

                Console.Write("Enter a word: ");
                str = Console.ReadLine();
                if (str == null || str.Length < 2)
                {
                    Console.WriteLine(str);
                    break;
                }

                firstChar = str[0];
                lastChar = str[str.Length - 1];

                str = str.Remove(0, 1); // ex
                                        // str = str.Substring(1, str.Length - 1);
                str = str.Remove(str.Length - 1, 1); // e
                str = str.Insert(0, lastChar.ToString()); // xe
                str = str.Insert(str.Length, firstChar.ToString()); // xes

                Console.WriteLine("Swapped first and last characters: {0}", str);

                Console.WriteLine("Keep going? Y/N");
                string decision = Console.ReadLine().ToUpper();

                if (decision == "N")
                {
                    break;
                }

            }
        }

        /**
         * Basic - 16 | CORRECTION 
         * 
         * Inside Main
         * 
         Console.WriteLine(First_last("w3resource"));
         Console.WriteLine(First_last("Python"));
         Console.WriteLine(First_last("x"));
         *
         */
        public static string First_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }

    

        /** Basic - 5)
         * ***********
         Write a program to swap two numbers **/
        static void TheSwapper()
        {
         
        }

        /**
         * Basic - 7)
         * **********
         * print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. **/
        static void TheOperationators()
        {
            int num1, num2;

            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("Okay now let's multiply xD {0} * {1} = and of course it's {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);

            Console.Read();
        }

        /**
         * Basic - 9)
         * **********
         * Avg of 4 numbers 
         * 
         * Note: Usage of Convert.ToDouble
         * **/
        static void TheAverageator()
        {
            double num1, num2, num3, num4;

            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 3rd number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 4th number: ");
            num4 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is {4}", num1, num2, num3, num4, average);
            Console.Read();

        }

        /**
         * Basic - 16)
         * 
         * remove a specified character from a non-empty string using index of a character
         * **/
        public static string Remove_char(string str, int n)
        {
            return str.Remove(n, 1); 
        }


    }
}
