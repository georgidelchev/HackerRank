using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MigratoryBirds
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            var birds = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var groups = birds
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .FirstOrDefault();

            Console.WriteLine(groups.Key);
        }
    }
}
