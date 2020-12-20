using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double countP1 = 0;
            double countP2 = 0;
            double countP3 = 0;

            double sumNumbersInPercentP1 = 0;
            double sumNumbersInPercentP2 = 0;
            double sumNumbersInPercentP3 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0) // p1
                {
                    countP1++;
                    sumNumbersInPercentP1 = countP1 / n * 100;
                }
                if (number % 3 == 0) // p2
                {
                    countP2++;
                    sumNumbersInPercentP2 = countP2 / n * 100;
                }
                if (number % 4 == 0) // p3
                {
                    countP3++;
                    sumNumbersInPercentP3 = countP3 / n * 100;
                }
            }
            Console.WriteLine($"{sumNumbersInPercentP1:f2}%");
            Console.WriteLine($"{sumNumbersInPercentP2:f2}%");
            Console.WriteLine($"{sumNumbersInPercentP3:f2}%");
        }
    }
}
