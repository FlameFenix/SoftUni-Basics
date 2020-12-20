using System;

namespace Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int result = 0;
            if (dayOfWeek == "Monday" ||
                dayOfWeek == "Tuesday" ||
                dayOfWeek == "Friday")
            {
                result = 12;
            }
            else if (dayOfWeek == "Wednesday" ||
                    dayOfWeek == "Thursday")
            {
                result = 14;
            }
            else if (dayOfWeek == "Saturday" ||
                      dayOfWeek == "Sunday")
            {
                result = 16;
            }
            Console.WriteLine(result);
        }
    }
}
