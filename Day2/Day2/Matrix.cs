using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Matrix
    {
        public static void InitMatrix()
        {
            int[,] matrix = new int[5, 5];
            matrix[2, 2] = 125;
            Console.WriteLine(matrix);
        }
        public static int[,] FillRandomMatrix(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            Random r = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(20);
                }
            }
            return matrix;
        }
        public static int[,] MatrixDiagonal(int baris, int kolom)
        {
            int[,] matrix = new int[baris, kolom];
            int count = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // diagonal (baris == kolom)
                    if (i == j)
                    {
                        matrix[i, j] = count++;
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

        public static int ScorsStudent(char[,] scors, char[] key)
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
            return count;
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
    }
}
