using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int grade = int.Parse(Console.ReadLine());

                if (grade < 38)
                {
                    Console.WriteLine(grade);
                }
                else
                {
                    int multipleOfFive = ((grade + 4) / 5) * 5;

                    Console.WriteLine(multipleOfFive - grade < 3 ? ((grade + 4) / 5) * 5 : grade);
                }
            }
        }
    }
}
