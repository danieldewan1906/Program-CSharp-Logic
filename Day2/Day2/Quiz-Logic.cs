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
        public static int[] CountNumberNo5(int[] arr)
        {
            int[] nilai = arr;
            Array.Sort(nilai);
            int count;
            int temp;

            for (int i = 0; i < nilai.Length; i++)
            {
                count = 0;
                //temp = nilai[i];
                for (int j = 0; j <= nilai.Length - 1; j++)
                {
                    if (nilai[i] == nilai[j])
                    {
                        count++;
                    }
                }
                if (i < nilai.Length - 1 && nilai[i] != nilai[i + 1])
                {
                    Console.WriteLine($"{nilai[i]} muncul sebanyak {count}");
                }
                else if (i == nilai.Length - 1)
                {
                    Console.WriteLine($"{nilai[i]} muncul sebanyak {count}");
                }

            }
            return nilai;
        }
        public static void ShiftingDuplicateNumberNo6(int[] nilai)
        {
            int[] arr = nilai;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                if (i < arr.Length - 1 && temp == arr[i + 1])
                {
                    for (int j = i; j < arr.Length; j++)
                    {
                        if (j == arr.Length - 1)
                        {
                            arr[j] = -1;
                        }
                        else
                        {
                            arr[j] = arr[j + 1];
                        }
                    }
                }
            }

            /*for (int i = 0; i < nilai.Length; i++)
            {
                int temp = arr[0];
                if (i < arr.Length - 1 && temp == arr[i + 1])
                {
                    for (int j = i; j < nilai.Length; j++)
                    {
                        if (j == arr.Length - 1)
                        {
                            arr[j] = -1;
                        }
                        else
                        {
                            arr[j] = arr[j + 1];
                        }
                    }
                }
            }*/
            DisplayArray(arr);
            //return arr;
        }

        public static int RemoveDuplicateNo7(int[] arr)
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

        public static char[] SumDuplicateElement(int arr)
        {
            char[] nilai = new char[arr];
            var value = "abcdefghijklmnopqrstuvwxyz";
            Random r = new Random();
            int count = 0;
            for (int i = 0; i < nilai.Length; i++)
            {
                nilai[i] = value[r.Next(0, 26)];
            }

            DisplayChar(nilai);
            Console.WriteLine();
            Console.WriteLine("----------RESULT----------");

            Array.Sort(nilai);
            for (int i = 0; i < nilai.Length; i++)
            {
                count = 0;
                for (int j = 0; j <= nilai.Length - 1; j++)
                {
                    if (nilai[i] == nilai[j])
                    {
                        count++;
                    }
                }
                if (i < nilai.Length - 1 && nilai[i] != nilai[i + 1])
                {
                    Console.Write($"{count} {nilai[i]} ");
                }
                else if (i == nilai.Length - 1)
                {
                    Console.Write($"{count} {nilai[i]} ");
                }

            }
            return nilai;
        }

        public static void ScorsStudent(char[,] scors, char[] key)
        {
            char[,] nilai = scors;
            char[] kunci = key;
            int count = 0;
            for (int i = 0; i < nilai.GetLength(0); i++)
            {
                count = 0;
                Console.Write($"Student-{i} : ");
                for (int j = 0; j < nilai.GetLength(1); j++)
                {
                    Console.Write($"{nilai[i, j]} ");
                    if (nilai[i, j] == kunci[j])
                    {
                        count += 1;
                    }
                }
                Console.WriteLine($"\nJawaban student {i} yang benar : {count}");
            }
        }
        public static int[,] MatrixDiagonalNo9(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int count = 5;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // diagonal (baris == kolom)
                    if (i == j)
                    {
                        matrix[i, j] = count--;
                    }
                    else if (j > i)
                    {
                        matrix[i, j] = 10;
                    }
                    else
                    {
                        matrix[i, j] = 20;
                    }
                }
            }
            return matrix;
        }
        public static int[,] SumMatrixDiagonal(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random r = new Random();
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(20);
                    // diagonal (baris == kolom)
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            DisplayMatrix(matrix);
            Console.WriteLine($"Total Sum Diagonal Value : {sum}");
            return matrix;
        }
        public static int[,] EmptyMidMatrix(int baris, int kolom)
        {
            int[,] array = new int[baris, kolom];
            int n = baris - 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i + j;
                    if (i != 0 && j != 0)
                    {
                        if (i != n && j != n)
                        {
                            array[i, j] = 0;
                        }
                    }
                }
            }
            return array;
        }
        public static int[,] SumMatriks(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int sum = 0;
            int sum2 = 0;
            int n = baris - 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i != n && j != n)
                    {
                        matrix[i, j] = i + j;
                        if (j <= n)
                        {
                            sum += matrix[i, j];
                            matrix[n, i] = matrix[i, n] = sum;

                            if (i == j)
                            {
                                sum2 += matrix[i, j];
                                matrix[n, n] = sum2;
                            }

                            if (j == n - 1)
                            {
                                sum = 0;
                            }
                        }
                    }
                }
            }

            return matrix;
        }


        public static void DisplayMatrix(int[,] matrix)
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

        public static void DisplayArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
        public static void DisplayChar(char[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
