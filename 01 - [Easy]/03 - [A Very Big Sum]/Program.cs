using System;
using System.Linq;
using System.Numerics;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsCount = int.Parse(Console.ReadLine());
            BigInteger[] numbers = new BigInteger[elementsCount];

            var nums = Console
                .ReadLine()
                .Split()
                .Select(BigInteger.Parse)
                .ToArray();

            BigInteger sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = nums[i];
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
