using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3a
{
    internal class Program
    {
        static int[,] GenerateMatrix(byte rows, byte cols)
        { 
            Random random = new Random();
            int[,] array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for(int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(100);
                }
            return array;
        }

        static void PrintMatrix(int[,] array) 
        {
            for (int i = 0; i < array.GetLength(0); i++) { 
                for (int k = 0; k < array.GetLength(1); k++)
                { 
                    Console.Write(array[i, k].ToString().PadLeft(5,' '));
                }
                Console.WriteLine();
            }
        }

        static void task1() 
        {
            byte rows = 4;
            byte cols = 3;
            int[,] matrix = GenerateMatrix(rows, cols);

            Console.WriteLine("Matrix:");
            PrintMatrix(matrix);
            Console.WriteLine("diagonal elements list:");
            for (int j = 0; j < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); j++)
            {
                Console.WriteLine($"{matrix[j, j]}  { matrix[j, matrix.GetLength(1) - j - 1]}");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task #1 \n =========================================================");
            task1();
            Console.ReadKey();
        }
    }
}
