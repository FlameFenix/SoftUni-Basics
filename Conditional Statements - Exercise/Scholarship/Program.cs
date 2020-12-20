using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minIncome = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(minIncome * 0.35);
            double highGradeScholarship = Math.Floor(grade * 25);

            string result = string.Empty;

            if (income <= minIncome && grade >= 5.50 && highGradeScholarship < socialScholarship)
            {
                result = $"You get a Social scholarship {socialScholarship} BGN";
            }
            else if (income <= minIncome && grade >= 5.50 && highGradeScholarship >= socialScholarship)
            {
                result = $"You get a scholarship for excellent results {highGradeScholarship} BGN";
            }
            else if (income > minIncome && grade >= 5.5)
            {
                result = $"You get a scholarship for excellent results {highGradeScholarship} BGN";
            }
            else if (income < minIncome && grade > 4.50)
            {
                result = $"You get a Social scholarship {socialScholarship} BGN";
            }
            else
            {
                result = $"You cannot get a scholarship!";
            }

            Console.WriteLine(result);
        }
    }
}
