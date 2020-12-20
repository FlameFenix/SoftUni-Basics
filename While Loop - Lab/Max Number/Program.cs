using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            while (true)
            {
                string number = Console.ReadLine();

                if (number == "Stop")
                {
                    Console.WriteLine(maxNumber);
                    break;
                }
                int input = int.Parse(number);
                if (input > maxNumber)
                {
                    maxNumber = input;
                }
            }
        }
    }
}
