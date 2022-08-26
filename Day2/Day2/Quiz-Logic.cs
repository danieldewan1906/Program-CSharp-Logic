using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class QuizLogic
    {
        public static int[] RandomArrayNo1(int[] arr)
        {
            int[] nilai = arr;
            return nilai;
        }
        public static int[] RandomIndexNo1(int[] arr)
        {
            Random rand = new Random();
            int[] nilai = arr;

            for (int i = 0; i < nilai.Length; i++)
            {
                int temp = nilai[i];
                int j = rand.Next(0, nilai.Length);
                nilai[i] = nilai[j];
                nilai[j] = temp;
            }
            return nilai;
        }
        public static int[] ShiftingElementNo2(int[] nilai)
        {
            int[] arr = nilai;
            int temp = nilai[0];
            for (int i = 1; i < nilai.Length; i++)
            {
                /*if (i < nilai.Length - 1)
                {
                    arr[i] = nilai[i + 1];
                }
                else
                {
                    arr[i] = temp;
                }*/
                arr[i - 1] = nilai[i];
            }
            arr[arr.Length - 1] = temp;

            return arr;
        }
        public static int[] LeftShiftingElementNo3(int[] nilai)
        {
            int[] arr = nilai;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rotasi Ke - {i} : ");
                int awal = nilai[0];
                for (int j = 0; j < nilai.Length - 1; j++)
                {
                    arr[j] = nilai[j + 1];
                }
                arr[nilai.Length - 1] = awal;
                DisplayArray(arr);
                nilai = arr;
            }
            return arr;
        }

        public static int[] RightShiftingElementNo4(int[] nilai)
        {
            int[] arr = nilai;

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rotasi Ke - {i} : ");
                int last = nilai[nilai.Length - 1];
                for (int j = nilai.Length - 1; j > 0; j--)
                {
                    arr[j] = nilai[(j - 1)];
                }
                arr[0] = last;
                DisplayArray(arr);
                nilai = arr;
            }
            return arr;
        }

        public static int RemoveDuplicate(int[] arr)
        {
            int[] nilai = arr;
            Array.Sort(nilai);
            int j = 0;

            for (int i = 0; i < nilai.Length - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    nilai[j++] = arr[i];
                }
            }
            nilai[j++] = arr[arr.Length - 1];

            for (int i = 0; i < j; i++)
            {
                arr[i] = nilai[i];
            }
            return j;
        }

        public static int SumCorrectTest(char[] key, int stud, int scor)
        {
            int[] siswa = new int[stud];
            char[] nilai = new char[scor];
            int count = 0;

            for (int i = 0; i < siswa.Length; i++)
            {
                Console.WriteLine($"Student - {i} : ");
                for (int j = 0; j < nilai.Length; j++)
                {
                    Console.Write($"Nilai {j} : ");
                    char sc = Convert.ToChar(Console.ReadLine());
                    nilai[j] = sc;
                    if (nilai[j] == key[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
