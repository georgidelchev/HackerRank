using System;
using System.Linq;

namespace DivisibleSumPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int size = input[0];
            int divisibleNumber = input[1];

            var arr = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(size)
                .ToList();

            int divisiblesCount = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if ((arr[i] + arr[j]) % divisibleNumber == 0)
                    {
                        divisiblesCount++;
                    }
                }

            }

            Console.WriteLine(divisiblesCount);
        }
    }
}
