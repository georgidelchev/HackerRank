using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = int.Parse(Console.ReadLine());

            var allOrders = new List<long>();

            for (int i = 0; i < orders; i++)
            {
                allOrders.Add(long.Parse(Console.ReadLine()));
            }

            var k = long.Parse(Console.ReadLine());

            var count = 0;

            foreach (var order in allOrders.OrderBy(o => o))
            {
                if (k < order)
                {
                    break;
                }

                k -= order;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
