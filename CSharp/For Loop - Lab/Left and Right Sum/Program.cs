using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int result = 0;
            int result2 = 0;

            string output = string.Empty;

            for (int i = 0; i < counter; i++)
            {
                int number = int.Parse(Console.ReadLine());
                result += number;
            }
            for (int i = 0; i < counter; i++)
            {
                int number = int.Parse(Console.ReadLine());
                result2 += number;
            }
            if (result == result2)
            {
                output = $"Yes, sum = {result}";
            }
            else if (result > result2)
            {
                result -= result2;
                output = $"No, diff = {result}";
            }
            else if (result < result2)
            {
                result2 -= result;
                output = $"No, diff = {result2}";
            }

            Console.WriteLine(output);
        }
    }
}
