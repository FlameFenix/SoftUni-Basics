using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourForExamp = int.Parse(Console.ReadLine());
            int minutesForExamp = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minutesOfArrival = int.Parse(Console.ReadLine());

            string output = string.Empty;
            string output2 = string.Empty;

            int timeForExamp = hourForExamp * 60 + minutesForExamp;
            int timeForArrival = hourOfArrival * 60 + minutesOfArrival;
            int resultMinutes = 0;
            int resultHours = 0;

            if (timeForArrival > timeForExamp)
            {
                if (timeForArrival - timeForExamp < 60)
                {
                    resultMinutes = timeForArrival - timeForExamp;
                    output = "Late";
                    output2 = $"{resultMinutes} minutes after the start";
                }
                else if (timeForArrival - timeForExamp >= 60)
                {
                    resultMinutes = (timeForArrival - timeForExamp) % 60;
                    resultHours = (timeForArrival - timeForExamp) / 60;
                    output = "Late";
                    output2 = $"{resultHours}:{resultMinutes:D2} hours after the start";
                }
            }

            else if (timeForArrival == timeForExamp || timeForExamp - timeForArrival <= 30)
            {
                if (timeForArrival == timeForExamp)
                {
                    output = "On time";
                }
                else if (timeForExamp - timeForArrival <= 30)
                {
                    resultMinutes = (timeForExamp - timeForArrival) % 60;
                    output = "On time";
                    output2 = $"{resultMinutes} minutes before the start";
                }

            }

            else if (timeForArrival < timeForExamp)
            {
                if (timeForExamp - timeForArrival < 60)
                {
                    resultMinutes = timeForExamp - timeForArrival;
                    output = "Early";
                    output2 = $"{resultMinutes} minutes before the start";
                }
                else if (timeForExamp - timeForArrival >= 60)
                {
                    resultMinutes = (timeForExamp - timeForArrival) % 60;
                    resultHours = (timeForExamp - timeForArrival) / 60;
                    output = "Early";
                    output2 = $"{resultHours}:{resultMinutes:D2} hours before the start";
                }

            }

            Console.WriteLine(output);
            Console.WriteLine(output2);
        }
    }
}
