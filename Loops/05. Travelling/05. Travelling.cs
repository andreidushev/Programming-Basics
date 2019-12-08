using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double savedMoney = 0;
                double budget = double.Parse(Console.ReadLine());

                while (savedMoney < budget)
                {
                    double moneyIN = double.Parse(Console.ReadLine());
                    savedMoney += moneyIN;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
