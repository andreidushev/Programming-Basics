﻿using System;

namespace _04._Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1++;
                }
                else if (num <= 399)
                {
                    p2++;
                }
                else if (num <= 599)
                {
                    p3++;
                }
                else if (num <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            Console.WriteLine($"{p1 / n * 100:F2}%");
            Console.WriteLine($"{p2 / n * 100:F2}%");
            Console.WriteLine($"{p3 / n * 100:F2}%");
            Console.WriteLine($"{p4 / n * 100:F2}%");
            Console.WriteLine($"{p5 / n * 100:F2}%");
        }
    }
}
