﻿using System;

namespace Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (hour >= 10 && hour <= 18)
            {
                if (dayOfWeek == "Monday" ||
                    dayOfWeek == "Tuesday" ||
                    dayOfWeek == "Wednesday" ||
                    dayOfWeek == "Thursday" ||
                    dayOfWeek == "Friday" ||
                    dayOfWeek == "Saturday")
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
