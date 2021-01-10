using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = 0;

            if (type == "square")
            {
                double square = double.Parse(Console.ReadLine());
                area = square * square;
            }

            else if (type == "rectangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                area = lenght * width;
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = radius * radius * Math.PI;
            }

            else if (type == "triangle")
            {
                double basee = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = basee * height / 2;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
