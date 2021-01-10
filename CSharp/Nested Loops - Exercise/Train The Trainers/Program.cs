using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryNumber = int.Parse(Console.ReadLine());
            double averageGradePerCycle = 0;
            double averageGradeFinal = 0;
            int countPresentations = 0;
            while (true)
            {
                string presentation = Console.ReadLine();
                if (presentation == "Finish")
                {
                    break;
                }
                countPresentations++;
                double gradesSum = 0;
                for (int i = 0; i < juryNumber; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    gradesSum += grades;
                    averageGradePerCycle = gradesSum / juryNumber;
                }
                Console.WriteLine($"{presentation} - {averageGradePerCycle:f2}.");
                averageGradeFinal += averageGradePerCycle;
            }
            averageGradeFinal /= countPresentations * 1.0;
            Console.WriteLine($"Student's final assessment is {averageGradeFinal:f2}.");
        }
    }
}
