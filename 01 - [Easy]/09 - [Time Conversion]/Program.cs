using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool success = DateTime.TryParse(input, out DateTime time);

            if (success)
            {
                Console.WriteLine(time.ToString("HH:mm:ss"));
            }
        }
    }
}
