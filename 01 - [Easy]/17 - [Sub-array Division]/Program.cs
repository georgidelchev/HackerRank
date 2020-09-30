using System;
using System.Linq;

namespace SubArrayDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var chocoBars = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(n)
                .ToList();

            var birthDayAndMonth = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int d = birthDayAndMonth[0];
            int m = birthDayAndMonth[1];

            int waysToSplitCounter = 0;

            for (int i = 0; i < (chocoBars.Count - m) + 1; i++)
            {
                var sum = chocoBars
                    .GetRange(i, m)
                    .Aggregate((x, y) => x + y);

                if (sum == d)
                {
                    waysToSplitCounter++;
                }
            }

            Console.WriteLine(waysToSplitCounter);
        }
    }
}
