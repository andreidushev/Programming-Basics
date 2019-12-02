using System;

namespace _01._Numbers_to_1000_end_with_7
{
    class NumbersEndWith7
    {
        static void Main()
        {
            for (int i = 1; i < 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
