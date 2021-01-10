using System;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double heightRoof = double.Parse(Console.ReadLine());

            double squareSide = height * length;
            double window = 1.5 * 1.5;
            double squareBothSides = 2 * squareSide - 2 * window;
            double backSide = height * height;
            double door = 1.2 * 2;
            double windowAndBackSide = 2 * backSide - door;
            double squareSides = squareBothSides + windowAndBackSide;
            double greenPaint = squareSides / 3.4;

            double rectangleRoof = 2 * (height * length);
            double triangleRoof = 2 * (height * heightRoof / 2);
            double squareRoof = rectangleRoof + triangleRoof;
            double redPaint = rectangleRoof / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
