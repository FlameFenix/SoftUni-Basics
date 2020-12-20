using System;

namespace Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;

            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    oddSum += numbers;

                    if (numbers > oddMax)
                    {
                        oddMax = numbers;
                    }
                    if (numbers < oddMin)
                    {
                        oddMin = numbers;
                    }

                }
                if (i % 2 == 0)
                {
                    evenSum += numbers;

                    if (numbers > evenMax)
                    {
                        evenMax = numbers;
                    }
                    if (numbers < evenMin)
                    {
                        evenMin = numbers;
                    }


                }

            }
            if (n > 1)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else if (n == 1)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum=0.00,");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum=0.00,");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum=0.00,");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
        }
    }
}
