using System;

namespace Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int cLass = 1;
            double sumRating = 0;
            double avarageRating = 0;
            int counterMinGrade = 0;
            string output = string.Empty;

            while (cLass <= 12)
            {
                double rating = double.Parse(Console.ReadLine());
                if (rating >= 4)
                {
                    sumRating += rating;
                    avarageRating = sumRating / cLass;
                    cLass++;
                    output = $"{name} graduated. Average grade: {avarageRating:f2}";
                }
                else if (rating < 4)
                {
                    counterMinGrade++;

                    if (counterMinGrade != 2)
                    {
                        output = $"{name} has been excluded at {cLass} grade";
                        break;
                    }

                }

            }

            Console.WriteLine(output);
        }
    }
}
