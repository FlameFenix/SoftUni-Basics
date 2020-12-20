using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double sum = 0.0;
            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    sum = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    sum = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    sum = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    sum = sales * 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    sum = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    sum = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    sum = sales * 0.10;
                }
                else if (sales > 10000)
                {
                    sum = sales * 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    sum = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    sum = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    sum = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    sum = sales * 0.145;
                }
            }
            double finalSum = sum;
            if (finalSum <= 0)
            {
                Console.WriteLine("error");
            }

            else
            {
                Console.WriteLine($"{finalSum:f2}");
            }
        }
    }
}
