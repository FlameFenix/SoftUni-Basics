using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double countP1 = 0;
            double countP2 = 0;
            double countP3 = 0;
            double countP4 = 0;
            double countP5 = 0;

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            string output = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    countP1 += 1;
                    p1 = countP1 / n * 100;
                }
                else if (number >= 200 && number <= 399)
                {
                    countP2 += 1;
                    p2 = countP2 / n * 100;
                }
                else if (number > 399 && number <= 599)
                {
                    countP3 += 1;
                    p3 = countP3 / n * 100;
                }
                else if (number > 599 && number <= 799)
                {
                    countP4 += 1;
                    p4 = countP4 / n * 100;
                }
                else if (number >= 800)
                {
                    countP5 += 1;
                    p5 = countP5 / n * 100;
                }

            }
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
