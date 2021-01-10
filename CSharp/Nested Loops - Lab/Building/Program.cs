using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            string output = string.Empty;

            for (int f = floors; f >= 1; f--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (f == floors)
                    {
                        output = "L";
                    }
                    else if (f % 2 == 0)
                    {
                        output = "O";
                    }
                    else if (f % 2 == 1)
                    {
                        output = "A";
                    }
                    Console.Write($"{output}{f}{r} ");
                }
                Console.WriteLine();
            }
        }
    }
}
