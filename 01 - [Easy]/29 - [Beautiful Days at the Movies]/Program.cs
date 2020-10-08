using System;
using System.Collections.Generic;
using System.Linq;

namespace BeautifulDaysAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int startingDay = input[0];
            int endingDay = input[1];
            int divisor = input[2];

            int daysCounter = 0;
            for (int i = startingDay; i <= endingDay; i++)
            {
                int currentNumber = i;
                int currentNumberCopy = currentNumber;
                var reversedNumber = 0;

                ReversingNumber(ref currentNumberCopy, ref reversedNumber);

                if ((currentNumber - reversedNumber) % divisor == 0)
                {
                    daysCounter++;
                }
            }

            Console.WriteLine(daysCounter);
        }

        private static void ReversingNumber(ref int currentNumberCopy, ref int reversedNumber)
        {
            while (currentNumberCopy > 0)
            {
                reversedNumber = reversedNumber * 10 + currentNumberCopy % 10;
                currentNumberCopy /= 10;
            }
        }
    }
}
