using System;
using System.Collections.Generic;
using System.Linq;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                var input = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                var studsCount = input[0];
                var cancellationThreshold = input[1];

                var arrivalTimes = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .Where(x => x <= 0)
                    .ToList();

                if (arrivalTimes.Count >= cancellationThreshold)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
