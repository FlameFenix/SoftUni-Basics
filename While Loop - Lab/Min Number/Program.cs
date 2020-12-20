using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            while (true)
            {
                string number = Console.ReadLine();

                if (number == "Stop")
                {
                    Console.WriteLine(minNumber);
                    break;
                }
                int input = int.Parse(number);
                if (input < minNumber)
                {
                    minNumber = input;
                }
            }
        }
    }
}
