using System;
using System.Linq;

namespace BetweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsCount = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int m = numsCount[0];
            int n = numsCount[1];

            var firstSequence = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(m)
                .ToList();

            var secondSequence = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(n)
                .ToList();

            int valids = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (firstSequence.TrueForAll(x => i % x == 0))
                {
                    if (secondSequence.TrueForAll(x => x % i == 0))
                    {
                        valids++;
                    }
                }
            }

            Console.WriteLine(valids);
        }
    }
}
