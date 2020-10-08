using System;
using System.Collections.Generic;
using System.Linq;

namespace UtopianTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int testCase = int.Parse(Console.ReadLine());

                int height = 1;
                for (int j = 1; j < testCase + 1; j++)
                {
                    if (j % 2 != 0)
                    {
                        height *= 2;
                    }
                    else
                    {
                        height++;
                    }
                }

                Console.WriteLine(height);
            }

        }
    }
}
