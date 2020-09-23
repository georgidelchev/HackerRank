using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var elements = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int rightSum = 0;
            int leftSum = 0;

            int m = size;
            int n = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                m -= 1;
                n += 1;
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == m)
                    {
                        leftSum += matrix[row, col];
                    }

                    if (col == n)
                    {
                        rightSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(Math.Abs(rightSum - leftSum));
        }
    }
}
