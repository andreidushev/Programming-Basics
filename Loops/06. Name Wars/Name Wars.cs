using System;

namespace _06._Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = 0;
            int max = 0;
            string namemax = "";
            int max1 = int.MinValue;

            while (true)
            {

                string name = Console.ReadLine();

                if (name == "STOP")
                    break;


                for (int i = 0; i < name.Length; i++)
                    current = current + name[i];

                if (current > max1 && current > max)
                {
                    max = current;
                    namemax = name;
                }
                current = 0;

            }
            Console.WriteLine($"Winner is {namemax} - {max}!");
        }
    }
}
