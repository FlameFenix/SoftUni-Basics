using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());

            double cakeSquare = cakeLenght * cakeWidth;
            double cakePieceSquare = 0;
            double finalSum = 0;
            bool isCakeEnough = true;

            while (isCakeEnough)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    break;
                }

                int cakePiece = int.Parse(command);
                cakePieceSquare += cakePiece;
                if (cakePieceSquare > cakeSquare)
                {
                    isCakeEnough = false;
                    finalSum = cakePieceSquare - cakeSquare;
                }
                else
                {
                    finalSum = cakeSquare - cakePieceSquare;
                }
            }
            if (isCakeEnough)
            {
                Console.WriteLine($"{finalSum} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {finalSum} pieces more.");
            }
        }
    }
}
