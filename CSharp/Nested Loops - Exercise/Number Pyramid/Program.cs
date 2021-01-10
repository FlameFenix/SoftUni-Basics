using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isNumberReached = false;
            int count = 1;
            for (int rows = 1; rows <= number; rows++)
            {
                for (int colls = 1; colls <= rows; colls++)
                {
                    Console.Write($"{count} ");
                    count++;
                    if (count > number)
                    {
                        isNumberReached = true;
                        break;
                    }

                }
                if (isNumberReached)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
