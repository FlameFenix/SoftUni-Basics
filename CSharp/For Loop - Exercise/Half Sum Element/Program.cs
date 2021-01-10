using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int numbersSum = 0;
            int maxNumber = int.MinValue;
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbersSum += number;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            int sumWithoutMaxNumber = numbersSum - maxNumber;
            if (sumWithoutMaxNumber == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumWithoutMaxNumber - maxNumber)}");
            }
        }
    }
}
