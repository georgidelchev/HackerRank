using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesByMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var nums = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(n)
                .ToList();

            var dict = new Dictionary<int, int>();

            int counter = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] = 0;
                }

                dict[nums[i]]++;

                if (dict[nums[i]] == 2)
                {
                    dict[nums[i]] = 0;
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
