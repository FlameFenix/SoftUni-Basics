using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumNumbers = 0;

            while (number > sumNumbers)
            {
                int nextNumber = int.Parse(Console.ReadLine());
                sumNumbers += nextNumber;
            }

            Console.WriteLine($"{sumNumbers}");
        }
    }
}
