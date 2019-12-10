using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (input != "stop")
            {
                int current = int.Parse(input);

                if (current < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                bool isNonPrime = false;
                int n = current / 2;

                for (int i = 2; i <= n; i++)
                {
                    if (current % i == 0)
                    {
                        isNonPrime = true;
                        break;
                    }
                }

                if (isNonPrime)
                {
                    nonPrimeSum += current;
                }
                else
                {
                    primeSum += current;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
