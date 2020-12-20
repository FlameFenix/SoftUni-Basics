using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            string output = string.Empty;
            string output2 = string.Empty;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += numbers;
                }
                else if (i % 2 != 0)
                {
                    oddSum += numbers;
                }
            }

            int diff = Math.Abs(evenSum - oddSum);

            if (evenSum == oddSum)
            {
                output = "Yes";
                output2 = $"Sum = {evenSum}";
            }
            else if (evenSum != oddSum)
            {
                output = "No";
                output2 = $"Diff = {diff}";
            }

            Console.WriteLine(output);
            Console.WriteLine(output2);
        }
    }
}
