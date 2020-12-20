using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            double savedMoney = 0;
            string output = string.Empty;

            while (true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                double budget = double.Parse(Console.ReadLine());
                while (true)
                {
                    double income = double.Parse(Console.ReadLine());
                    savedMoney += income;
                    if (budget <= savedMoney)
                    {
                        savedMoney = 0;
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                    else if (budget <= income)
                    {
                        savedMoney = 0;
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }
            }
        }
    }
}
