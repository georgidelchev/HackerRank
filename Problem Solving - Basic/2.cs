using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            var matrix = new long[rows, cols];

            for (var row = 0; row < rows; row++)
            {
                var data = Console
                    .ReadLine()
                    .Split()
                    .Select(long.Parse)
                    .ToList();

                for (var col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }

            var count = 0;

            for (var row = 0; row < rows; row++)
            {
                for (var col = row + 1; col < rows; col++)
                {
                    if (matrix[row, 0] * matrix[col, 1] ==
                        matrix[row, 1] * matrix[col, 0])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
