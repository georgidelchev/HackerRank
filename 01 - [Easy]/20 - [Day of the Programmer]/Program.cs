using System;

namespace DayOfTheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            string outputDate = "";
            if (year == 1918)
            {
                outputDate = "26.09." + year;
            }
            else if (isGivenYearIsLeap(year))
            {
                outputDate = "12.09." + year;
            }
            else
            {
                outputDate = "13.09." + year;
            }

            Console.WriteLine(outputDate);
        }

        private static bool isGivenYearIsLeap(int year)
            => ((year <= 1917) && (year % 4 == 0)) ||
               ((year >= 1919) && (year % 400 == 0)) ||
               ((year % 4 == 0) && (year % 100 != 0));

    }
}
