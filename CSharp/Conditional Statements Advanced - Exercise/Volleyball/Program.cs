using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            double holidays = int.Parse(Console.ReadLine());
            int weekendsOwnTown = int.Parse(Console.ReadLine());
            double weekendsInSofia = 0;
            double sumOfPlaying = 0;
            double playForOneYear = 0;
            if (typeOfYear == "leap")
            {
                weekendsInSofia = (48 - weekendsOwnTown) * 0.75;
                holidays = holidays * 0.66667;
                sumOfPlaying = weekendsInSofia + weekendsOwnTown + holidays;
                playForOneYear = sumOfPlaying * 1.15;
                playForOneYear = Math.Floor(playForOneYear);


            }
            else if (typeOfYear == "normal")
            {
                weekendsInSofia = (48 - weekendsOwnTown) * 0.75;
                holidays = holidays * 0.66667;
                sumOfPlaying = weekendsInSofia + weekendsOwnTown + holidays;
                playForOneYear = sumOfPlaying;
                playForOneYear = Math.Floor(playForOneYear);
            }
            Console.WriteLine(playForOneYear);
        }
    }
}
