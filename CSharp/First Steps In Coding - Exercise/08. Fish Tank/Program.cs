using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double weidth = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aquaSize = lenght * weidth * height;
            double littersInAqua = aquaSize * 0.001;
            double percentAgain = percent * 0.01;
            double littersNeed = littersInAqua * (1 - percentAgain);

            Console.WriteLine($"{littersNeed}");
        }
    }
}
