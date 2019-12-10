using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            double totalMark = 0;
            int counter = 0;

            while (presentation != "Finish")
            {
                double sumMarks = 0;
                for (int i = 1; i <= juryCount ; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    sumMarks += mark;
                }
                double grade = sumMarks / juryCount;
                totalMark += grade;
                Console.WriteLine($"{presentation} - {grade:F2}.");
                counter++;
                presentation = Console.ReadLine();
            }
            double avarageGrade = totalMark / counter;
            Console.WriteLine($"Student's final assessment is {avarageGrade:F2}.");
        }
    }
}
