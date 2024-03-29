﻿using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            Console.WriteLine($"{p1 * 1.0 / n * 100:F2}%");
            Console.WriteLine($"{p2 * 1.0 / n * 100:F2}%");
            Console.WriteLine($"{p3 * 1.0 / n * 100:F2}%");
        }
    }
}
