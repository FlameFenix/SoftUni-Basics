using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= endNumber; i++)
            {
                int number = i;
                int evenSum = 0;
                int oddSum = 0;

                bool isEven = true;
                while (number > 0)
                {
                    int lastDigit = number % 10;
                    if (isEven)
                    {
                        evenSum += lastDigit;
                        isEven = false;
                    }
                    else
                    {
                        oddSum += lastDigit;
                        isEven = true;
                    }
                    number /= 10;
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
                else
                {

                }
            }
        }
    }
}
