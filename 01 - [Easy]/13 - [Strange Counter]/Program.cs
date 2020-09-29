using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace StrangeCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            long time = long.Parse(Console.ReadLine());
            long startNumber = 3;

            while (time > startNumber)
            {
                time -= startNumber;
                startNumber *= 2;
            }

            Console.WriteLine(startNumber - time + 1);
        }
    }
}
