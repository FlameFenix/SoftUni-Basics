using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            string result = null;

            if (speed <= 10)
            {
                result = "slow";
            }
            else if (speed > 10 && speed <= 50)
            {
                result = "average";
            }
            else if (speed > 50 && speed <= 150)
            {
                result = "fast";
            }
            else if (speed > 150 && speed <= 1000)
            {
                result = "ultra fast";
            }
            else if (speed > 1000)
            {
                result = "extremely fast";
            }

            Console.WriteLine(result);
        }
    }
}
