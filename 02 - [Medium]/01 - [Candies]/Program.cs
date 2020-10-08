using System;
using System.Collections.Generic;
using System.Linq;

namespace Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var child = new List<long>(size);
            var candies = new List<long>(size);

            child.Add(int.Parse(Console.ReadLine()));
            candies.Add(1);

            for (int i = 1; i < size; i++)
            {
                child.Add(int.Parse(Console.ReadLine()));
                candies.Add(1);

                if (child[i] > child[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                }
            }

            for (int i = size - 1; i > 0; i--)
            {
                if (child[i] < child[i - 1])
                {
                    candies[i - 1] = Math.Max(candies[i - 1], candies[i] + 1);
                }
            }

            Console.WriteLine(candies.Sum());
        }
    }
}
