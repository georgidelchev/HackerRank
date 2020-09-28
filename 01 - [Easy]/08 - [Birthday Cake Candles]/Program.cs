using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var candles = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(n)
                .ToList();

            int equalCandlesCount = 0;
            int maxCandle = candles.Max();

            for (int i = 0; i < candles.Count; i++)
            {
                if (maxCandle == candles[i])
                {
                    equalCandlesCount++;
                }
            }

            Console.WriteLine(equalCandlesCount);
        }
    }
}
