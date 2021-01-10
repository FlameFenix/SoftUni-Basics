using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    break;
                }

                double number = double.Parse(input);
                if (number <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else if (number != 0)
                {
                    Console.WriteLine($"Increase: {number:f2}");
                    sum += number;
                }
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
