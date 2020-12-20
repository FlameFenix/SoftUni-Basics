using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int MaxValue = int.MinValue;
            int MinValue = int.MaxValue;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > MaxValue)
                {
                    MaxValue = number;
                }
                if (number < MinValue)
                {
                    MinValue = number;
                }

            }

            Console.WriteLine($"Max number: {MaxValue}");
            Console.WriteLine($"Min number: {MinValue}");
        }
    }
}
