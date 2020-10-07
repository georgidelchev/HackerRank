using System;
using System.Collections.Generic;
using System.Linq;

namespace ViralAdvertising
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double shares = 5;
            double totalLikes = 0;

            for (int i = 0; i < days; i++)
            {
                shares = Math.Floor(shares / 2);
                totalLikes += shares;
                shares *= 3;
            }
            Console.WriteLine(totalLikes);
        }
    }
}
