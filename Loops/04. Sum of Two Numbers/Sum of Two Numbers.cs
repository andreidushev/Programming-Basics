using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            bool hasMagical = false;
            int counter = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    counter++;

                    int sum = i + j;

                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {sum})");
                        hasMagical = true;
                        break;
                    }
                }
                if (hasMagical)
                {
                    break;
                }
            }
            if (!hasMagical)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
