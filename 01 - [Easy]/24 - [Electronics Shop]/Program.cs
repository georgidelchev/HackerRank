using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int budget = nums[0];
            int keyboardsCount = nums[1];
            int usbDrivesCount = nums[2];

            var keyboardsPrice = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(keyboardsCount)
                .Where(x => x < budget)
                .ToList();

            var usbDrivesPrice = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(usbDrivesCount)
                .Where(x => x < budget)
                .ToList();

            int maxPrice = 0;
            for (int i = 0; i < keyboardsPrice.Count; i++)
            {
                for (int j = 0; j < usbDrivesPrice.Count; j++)
                {
                    if ((keyboardsPrice[i] + usbDrivesPrice[j] > maxPrice) &&
                        (keyboardsPrice[i] + usbDrivesPrice[j] <= budget))
                    {
                        maxPrice = keyboardsPrice[i] + usbDrivesPrice[j];
                    }
                }
            }

            if (maxPrice > 0)
            {
                Console.WriteLine(maxPrice);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
