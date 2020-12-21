using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            double restdays = double.Parse(Console.ReadLine());

            double minutesPerYear = 30000;
            double playPerWorkDaysInMinutes = 63;
            double playPerRestDaysInMinutes = 127;
            double daysInOneYear = 365;

            double workDays = daysInOneYear - restdays;

            double playPerWorkDays = workDays * playPerWorkDaysInMinutes;
            double restDaysPlay = restdays * playPerRestDaysInMinutes;
            double playMinutes = playPerWorkDays + restDaysPlay;
            double diffrence = minutesPerYear - playMinutes;
            double diffrenceInHours = (diffrence - diffrence % 60) / 60;
            double diffrenceInMinutes = (diffrence - diffrenceInHours * 60);
            double diffrenceInSecondCase = playMinutes - minutesPerYear;
            double diffrenceInHoursSecondCase = (diffrenceInSecondCase - diffrenceInSecondCase % 60) / 60;
            double diffrenceInMinutesSecondCase = (diffrenceInSecondCase - diffrenceInHoursSecondCase * 60);

            if (playMinutes < minutesPerYear)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{diffrenceInHours} hours and {diffrenceInMinutes} minutes less for play");
            }
            else if (playMinutes > minutesPerYear)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{diffrenceInHoursSecondCase} hours and {diffrenceInMinutesSecondCase} minutes more for play");
            }
        }
    }
}
