using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            var alicePoints = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var bobPoints = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int aliceTotalPoints = 0;
            int bobTotalPoints = 0;

            for (int i = 0; i < alicePoints.Count; i++)
            {
                int comparing = alicePoints[i].CompareTo(bobPoints[i]);

                if (comparing > 0)
                {
                    aliceTotalPoints++;
                }
                else if (comparing < 0)
                {
                    bobTotalPoints++;
                }
            }

            Console.WriteLine($"{aliceTotalPoints} {bobTotalPoints}");
        }
    }
}
