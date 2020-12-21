using System;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int overnight = int.Parse(Console.ReadLine());

            double studentsTax = 0;
            string sportType = string.Empty;
            string output = string.Empty;

            if (typeOfGroup == "boys")
            {
                if (season == "Winter")
                {
                    studentsTax = students * 9.60 * overnight;
                    sportType = "Judo";
                }
                else if (season == "Spring")
                {
                    studentsTax = students * 7.20 * overnight;
                    sportType = "Tennis";
                }
                else if (season == "Summer")
                {
                    studentsTax = students * 15 * overnight;
                    sportType = "Football";
                }


            }
            else if (typeOfGroup == "girls")
            {
                if (season == "Winter")
                {
                    studentsTax = students * 9.60 * overnight;
                    sportType = "Gymnastics";
                }
                else if (season == "Spring")
                {
                    studentsTax = students * 7.20 * overnight;
                    sportType = "Athletics";
                }
                else if (season == "Summer")
                {
                    studentsTax = students * 15 * overnight;
                    sportType = "Volleyball";
                }
            }
            else if (typeOfGroup == "mixed")
            {
                if (season == "Winter")
                {
                    studentsTax = students * 10 * overnight;
                    sportType = "Ski";
                }
                else if (season == "Spring")
                {
                    studentsTax = students * 9.50 * overnight;
                    sportType = "Cycling";
                }
                else if (season == "Summer")
                {
                    studentsTax = students * 20 * overnight;
                    sportType = "Swimming";
                }
            }

            if (students >= 50)
            {
                studentsTax *= 0.50;
            }
            else if (students >= 20 && students < 50)
            {
                studentsTax *= 0.85;
            }
            else if (students >= 10 && students < 20)
            {
                studentsTax *= 0.95;
            }
            output = $"{sportType} {studentsTax:f2} lv.";
            Console.WriteLine(output);
        }
    }
}
