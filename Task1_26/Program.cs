using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of matrix' sides:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = generateRndMatrix(n);

            showMatrix(matrix);

            mainTaskFunc(matrix);
        }


        static int[,] generateRndMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            Random rnd = new Random();
            int rndNum;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        rndNum = rnd.Next(0, 2);
                    }
                    else
                    {
                        rndNum = rnd.Next(0, 100);
                    }
                    matrix[i, j] = rndNum;
                }
            }
            return matrix;
        }


        static void showMatrix(int[,] matrix)
        {
            int size = matrix.GetUpperBound(0) + 1;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


        static void mainTaskFunc(int[,] matrix)
        {
            int size = matrix.GetUpperBound(0) + 1;
            for (int i = 0; i < size; i++)
            {
                int sumToReturn = 0;
                if (matrix[i, i] == 0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        sumToReturn += matrix[i, j];
                    }
                    Console.WriteLine("Line " + (i + 1) + " sum: " + sumToReturn);
                }
            }
        }
    }
}
