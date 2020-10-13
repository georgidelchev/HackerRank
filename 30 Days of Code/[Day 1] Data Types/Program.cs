using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank";

            int i2 = int.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine());
            string s2 = Console.ReadLine();

            Console.WriteLine(i + i2);
            Console.WriteLine($"{d + d2:f1}");
            Console.WriteLine(s + " " + s2);
        }
    }
}
