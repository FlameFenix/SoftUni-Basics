using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isTrue = false;
            string output = string.Empty;
            for (int x1 = startNumber; x1 <= endNumber; x1++)
            {
                for (int x2 = startNumber; x2 <= endNumber; x2++)
                {
                    counter++;
                    int sum = x1 + x2;
                    if (sum == magicalNumber)
                    {
                        output = $"Combination N:{counter} ({x1} + {x2} = {sum})";
                        isTrue = true;
                        break;
                    }
                    else
                    {
                        output = $"{counter} combinations - neither equals {magicalNumber}";
                    }
                }
                if (isTrue == true)
                {
                    break;
                }
            }
            Console.WriteLine(output);
        }
    }
}
