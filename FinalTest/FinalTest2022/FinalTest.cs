using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2022
{
    internal class FinalTest
    {
        public static int NumberFrogJump(int x, int y, int k)
        {
            int result = 0;
            while (x < y)
            {
                result += 1;
                x += k;
            }
            return result;
        }

        public static int Factorial(int n)
        {
            int faktorial = 1;
            for (int i = 1; i <= n; i++)
            {
                faktorial *= i;
            }
            return faktorial;
        }

        public static int CalculationSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int Fibonacci(int n)
        {
            int fibo = 0;
            int temp = 0;
            int temp2 = 1;
            for (int i = 1; i < n; i++)
            {
                fibo = temp + temp2;
                temp = temp2;
                temp2 = fibo;
            }
            return fibo;
        }

        public static void ShowFibonacci(int n)
        {
            int fibo = 0;
            int temp = 0;
            int temp2 = 1;
            for (int i = 1; i <= n; i++)
            {
                fibo = temp + temp2;
                Console.WriteLine($"{temp2}");
                temp = temp2;
                temp2 = fibo;
            }
        }

        public static bool CheckKurawal(string input)
        {
            bool status = false;

            if (input.Length % 2 == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }

        public static bool IsAnagram(string s1, string s2)
        {
            bool status = false;
            char[] text = s1.ToLower().ToCharArray();
            char[] text2 = s2.ToLower().ToCharArray();
            Array.Sort(text);
            Array.Sort(text2);

            if (text.Length == text2.Length)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i].ToString() == text2[i].ToString())
                    {
                        status = true;
                    }
                }
            }
            return status;
        }

        public static int[,] Matrix1(int baris, int kolom)
        {
            int[,] matrik = new int[baris, kolom];
            int count = 10;
            int n = kolom - 1;

            for (int i = 0; i < matrik.GetLength(0); i++)
            {
                count = 10;
                for (int j = 0; j < matrik.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        matrik[i, j] = count--;
                    }
                    else if (i == 1)
                    {
                        if (j < n)
                        {
                            matrik[i, j] = count--;
                        }
                    }
                    else if (i == 2)
                    {
                        if (j < n - 1)
                        {
                            matrik[i, j] = count--;
                        }
                    }
                    else if (i == 3)
                    {
                        if (j < n - 2)
                        {
                            matrik[i, j] = count--;
                        }
                    }
                    else if (i == 4)
                    {
                        if (j == 0)
                        {
                            matrik[i, j] = 10;
                        }
                    }
                }
            }
            return matrik;
        }

        public static int[,] Matrix2(int baris, int kolom)
        {
            int[,] matrik = new int[baris, kolom];
            int count = 0;
            int n = kolom - 1;

            for (int i = 0; i < matrik.GetLength(0); i++)
            {
                //count++;
                for (int j = 0; j < matrik.GetLength(1); j++)
                {
                    if (j >= i)
                    {
                        matrik[i, j] = count++;
                    }
                }
            }
            return matrik;
        }

        public static void DisplayMatrik(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) //looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //looping kolom
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayMatrik2(int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) //looping baris
            {
                for (int i = 0; i < matrix.GetLength(0); i++) //looping kolom
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
