using System;
using System.Collections.Generic;
using System.Linq;

namespace SherlockAndTheValidString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console
                .ReadLine()
                .ToCharArray();

            var dict = new Dictionary<char, long>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict[input[i]] = 0;
                }

                dict[input[i]]++;
            }

            dict = dict
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            var nums = dict.Values.ToList();

            var max = nums.Max();
            var min = nums.Min();

            var minOcc = dict.Where(x => x.Value == min).Count();
            var maxOcc = dict.Where(x => x.Value == max).Count();

            int index = 1;

            if (maxOcc > minOcc)
            {
                index = nums.Count;
            }

            if (nums.All(x => x == nums[0]))
            {
                Console.WriteLine("YES");
            }
            else
            {
                nums[index - 1]--;

                if (nums[index - 1] == 0)
                {
                    nums.RemoveAt(index - 1);
                }

                if (nums.All(x => x == nums[0]))
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
}
