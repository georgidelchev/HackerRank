using System;
using System.Linq;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesCount = int.Parse(Console.ReadLine());

            var scores = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(gamesCount)
                .ToList();

            int highestScoreBrokes = 0;
            int lowestScoreBrokes = 0;

            int min = scores[0];
            int max = scores[0];

            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] > max)
                {
                    highestScoreBrokes++;
                    max = scores[i];
                }
                else if (scores[i] < min)
                {
                    lowestScoreBrokes++;
                    min = scores[i];
                }
            }

            Console.WriteLine($"{highestScoreBrokes} {lowestScoreBrokes}");
        }
    }
}
