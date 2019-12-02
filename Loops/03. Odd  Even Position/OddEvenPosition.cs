using System;

namespace _03._Odd__Even_Position
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;

            double oddMinNum = double.MaxValue;
            double oddMaxNum = double.MinValue;
            double evenMinNum = double.MaxValue;
            double evenMaxNum = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;

                    if (evenMinNum > num)
                    {
                        evenMinNum = num;
                    }
                    if (evenMaxNum < num)
                    {
                        evenMaxNum = num;
                    }
                }
                else
                {
                    oddSum += num;

                    if (oddMinNum > num)
                    {
                        oddMinNum = num;
                    }
                    if (oddMaxNum < num)
                    {
                        oddMaxNum = num;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:F2},");

            if (n > 0)
            {
                Console.WriteLine($"OddMin={oddMinNum:F2},");
                Console.WriteLine($"OddMax={oddMaxNum:F2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:F2},");

            if (n > 1)
            {
                Console.WriteLine($"EvenMin={evenMinNum:F2},");
                Console.WriteLine($"EvenMax={evenMaxNum:F2}");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }

        }
    }
}
