using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecPerMeter = double.Parse(Console.ReadLine());


            double swimmingTime = distanceInMeters * timeInSecPerMeter;
            double distanceSlow = Math.Floor(distanceInMeters / 15) * 12.5;
            double timeForWin = swimmingTime + distanceSlow;
            double timeForLoose = recordInSeconds - timeForWin;

            if (recordInSeconds > timeForWin)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeForWin:f2} seconds.");
            }

            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(timeForLoose):f2} seconds slower.");
            }
        }
    }
}
