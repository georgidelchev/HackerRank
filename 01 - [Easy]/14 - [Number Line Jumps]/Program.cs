using System;
using System.Linq;

namespace NumberLineJumps
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int x1 = list[0];
            int v1 = list[1];

            int x2 = list[2];
            int v2 = list[3];

            if ((x2 - x1) * (v2 - v1) < 0 &&
                (x2 - x1) % (v2 - v1) == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
