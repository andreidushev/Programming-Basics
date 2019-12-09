using System;

namespace Coding
{
    class Coding
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0 ; i--)
            {
                char currentDigit = input[i];
                int currentDigitToNumber = int.Parse(currentDigit.ToString());

                if (currentDigitToNumber == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }
                for (int n = 1; n <= currentDigitToNumber; n++)
                {
                    Console.Write((char)(currentDigitToNumber + 33));
                }
                Console.WriteLine();
            }
        }
    }
}
