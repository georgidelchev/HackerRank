using System;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            var nums = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(numbersCount)
                .ToList();

            int negativesCounter = 0;
            int zerosCounter = 0;
            int positivesCounter = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 0)
                {
                    negativesCounter++;
                }
                else if (nums[i] == 0)
                {
                    zerosCounter++;
                }
                else
                {
                    positivesCounter++;
                }
            }

            Console.WriteLine($"{(double)positivesCounter / nums.Count:f6}");
            Console.WriteLine($"{(double)negativesCounter / nums.Count:f6}");
            Console.WriteLine($"{(double)zerosCounter / nums.Count:f6}");
        }
    }
}
