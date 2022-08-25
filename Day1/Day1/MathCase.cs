using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class MathCase
    {
        /** case 1 : input bilangan 3digit lalu konversi ke dollar
         * input : 520, output : $50=10, $30=0, $20=1
         **/
        public static void ATM()
        {
            int digit1, digit2, digit3, sisa;
            Console.Write("Enter Money : ");
            int number = Convert.ToInt32(Console.ReadLine());

            digit1 = number / 50_000;
            sisa = number % 50_000;

            digit2 = sisa / 10_000;
            sisa %= 10_000;

            digit3 = sisa / 5_000;
            sisa %= 5_000;

            Console.WriteLine("Rp50.000 = " + digit1 + ", Rp10.000 = " + digit2 + ", Rp5.000 = " + digit3 + ", sisa = " + sisa);

        }
        /** input bilangan : 2345
            output : 2+3+4+5 = 15 **/
        public static void SumDigit()
        {
            int digit1, digit2, digit3, r;
            Console.Write("Enter 4 Digit : ");
            int number = Convert.ToInt32(Console.ReadLine());

            digit1 = number / 1000;
            r = number % 1000;

            digit2 = r / 100;
            r %= 100;

            digit3 = r / 10;
            r %= 10;

            int sum = digit1 + digit2 + digit3 + r;
            Console.WriteLine("Total Sum  : " + sum);

        }
        /** input bilangan : 2345
            output : 5432 **/
        public static void ReverseDigit()
        {
            int digit1, digit2, digit3, r;
            Console.Write("Enter 4 Digit : ");
            int number = Convert.ToInt32(Console.ReadLine());

            digit1 = number / 1000;
            r = number % 1000;

            digit2 = r / 100;
            r %= 100;

            digit3 = r / 10;
            r %= 10;

            string reverse = r + "" + digit3 + "" + digit2 + "" + digit1;
            Console.WriteLine("Total Reverse  : " + reverse);
        }
        public static void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        //prime number
        public static bool PrimeNumber(int n)
        {
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
