using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lenghtFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());


            double sumFreeSpace = widthFreeSpace * lenghtFreeSpace * heightFreeSpace;
            double sumOfBoxes = 0;
            double finalSum = 0;
            string output = string.Empty;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    break;
                }

                int boxes = int.Parse(command);
                sumOfBoxes += boxes;

                if (sumFreeSpace >= sumOfBoxes)
                {
                    finalSum = sumFreeSpace - sumOfBoxes;
                    output = $"{finalSum} Cubic meters left.";
                }
                if (sumFreeSpace < sumOfBoxes)
                {
                    sumOfBoxes -= sumFreeSpace;
                    finalSum = sumOfBoxes;
                    output = $"No more free space! You need {finalSum} Cubic meters more.";
                    break;
                }
            }

            Console.WriteLine(output);
        }
    }
}
