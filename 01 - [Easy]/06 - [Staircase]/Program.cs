using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(new string(' ', i - 1) + new string('#', n - (i - 1)));
            }
        }
    }
}
