using System;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            int square = side * side;
            Console.WriteLine(square);
        }
    }
}
