using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var moves = Console
                .ReadLine()
                .ToCharArray();

            int valleysCount = 0;
            int seaLvl = 0;

            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'D')
                {
                    seaLvl--;
                }
                else
                {
                    seaLvl++;
                }

                if (moves[i] == 'U' && seaLvl == 0)
                {
                    valleysCount++;
                }
            }

            Console.WriteLine(valleysCount);
        }
    }
}
