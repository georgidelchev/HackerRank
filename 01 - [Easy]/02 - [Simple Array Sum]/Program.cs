using System;
using System.Linq;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());

            var arr = new int[numsCount];

            var nums = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            AddingNumbers(arr, nums);

            Console.WriteLine(arr.Sum());
        }

        private static void AddingNumbers(int[] arr, int[] nums)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = nums[i];
            }
        }
    }
}
