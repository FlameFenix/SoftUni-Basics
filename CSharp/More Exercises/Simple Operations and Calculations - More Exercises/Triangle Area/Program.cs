using System;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());

            double area = side * high / 2;

            Console.WriteLine($"{area:F2}");
        }
    }
}
