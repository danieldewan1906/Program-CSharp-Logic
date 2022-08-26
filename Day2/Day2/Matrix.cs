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
                        matrix[i,j] = 10;
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
                Console.Write($"Student-{i} : ");
                for (int j = 0; j < nilai.GetLength(1); j++)
                {
                    Console.Write(nilai[i,j]);
                    if (nilai[i,j] == kunci[j])
                    {
                        count += 1;
                    }
                }
            }
            return count;
        }
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++) //looping baris
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //looping kolom
                {
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
