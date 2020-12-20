using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double rest = double.Parse(Console.ReadLine());
            double restInCoin = Math.Round(rest * 100);
            int countCoins = 0;
            while (restInCoin >= 0)
            {
                if (restInCoin >= 200)
                {
                    restInCoin -= 200;
                    countCoins++;
                    continue;
                }
                if (restInCoin >= 100)
                {
                    restInCoin -= 100;
                    countCoins++;
                    continue;
                }
                if (restInCoin >= 50)
                {
                    restInCoin -= 50;
                    countCoins++;
                    continue;
                }
                if (restInCoin >= 20)
                {
                    restInCoin -= 20;
                    countCoins++;
                    continue;
                }
                if (restInCoin >= 10)
                {
                    restInCoin -= 10;
                    countCoins++;
                    continue;
                }
                if (restInCoin >= 5)
                {
                    restInCoin -= 5;
                    countCoins++;
                    continue;
                }
                if (restInCoin >= 2)
                {
                    restInCoin -= 2;
                    countCoins++;
                    continue;
                }
                if (restInCoin > 0)
                {
                    restInCoin -= 1;
                    countCoins++;
                    continue;
                }
                Console.WriteLine(countCoins);
                break;
            }
        }
    }
}
