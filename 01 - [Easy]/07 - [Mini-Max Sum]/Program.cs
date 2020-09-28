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
            var arr = Console
                .ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            Console.WriteLine($"{arr.Sum() - arr.Max()} {arr.Sum() - arr.Min()}");
        }
    }
}
