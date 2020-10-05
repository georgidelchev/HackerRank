using System;
using System.Collections.Generic;
using System.Linq;

namespace DrawingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesCount = int.Parse(Console.ReadLine());
            int pageToTurnTo = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Min(pageToTurnTo / 2, pagesCount / 2 - pageToTurnTo / 2));
        }
    }
}
