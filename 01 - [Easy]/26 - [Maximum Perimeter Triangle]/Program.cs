using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumPerimeterTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> intParseFunc = x => int.Parse(x);

            int size = int.Parse(Console.ReadLine());

            var nums = Console
                .ReadLine()
                .Split()
                .Select(intParseFunc)
                .OrderBy(x => x)
                .Take(size)
                .ToList();

            var max = new List<int>();
            var maxSum = int.MinValue;

            for (int i = 0; i < nums.Count - 2; i++)
            {
                int firstNumber = nums[i];
                int secondNumber = nums[i + 1];
                int thirdNumber = nums[i + 2];

                if (firstNumber + secondNumber > thirdNumber)
                {
                    if (firstNumber + secondNumber + thirdNumber > maxSum)
                    {
                        maxSum = firstNumber + secondNumber + thirdNumber;

                        max.Clear();
                        max.Add(firstNumber);
                        max.Add(secondNumber);
                        max.Add(thirdNumber);
                    }
                }
            }

            if (max.Any())
            {
                Console.WriteLine(string.Join(" ", max));

            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
