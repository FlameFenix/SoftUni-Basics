using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int allowedBadRating = int.Parse(Console.ReadLine());

            int countBadRating = 0;
            double countExams = 0;
            double countRating = 0;
            double avarageRating = 0;
            string lastExam = string.Empty;
            string output = string.Empty;
            string output2 = string.Empty;
            string output3 = string.Empty;

            while (true)
            {
                string exam = Console.ReadLine();

                if (exam == "Enough")
                {
                    Console.WriteLine($"Average score: {avarageRating:f2}");
                    Console.WriteLine($"Number of problems: {countExams}");
                    Console.WriteLine($"Last problem: {lastExam}");
                    break;
                }

                int rating = int.Parse(Console.ReadLine());

                if (exam != "Enough")
                    countExams++;
                countRating += rating;
                avarageRating = countRating / countExams;
                lastExam = exam;
                {
                    if (rating <= 4)
                    {
                        countBadRating++;
                        if (allowedBadRating <= countBadRating)
                        {
                            Console.WriteLine($"You need a break, {countBadRating} poor grades.");
                            break;
                        }
                    }
                }
            }
        }
    }
}
