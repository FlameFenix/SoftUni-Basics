using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int standardTicketsCount = 0;
            int studentTicketsCount = 0;
            int kidTicketsCount = 0;
            int soldTicketsCounter = 0;
            while (true)
            {
                string movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    break;
                }
                int capacity = int.Parse(Console.ReadLine());


                int ticketsCount = 0;

                while (true)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }

                    if (ticketType == "standard")
                    {
                        standardTicketsCount++;
                    }
                    else if (ticketType == "student")
                    {
                        studentTicketsCount++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicketsCount++;
                    }
                    ticketsCount++;
                    soldTicketsCounter++;
                    if (capacity == ticketsCount)
                    {
                        break;
                    }
                }
                double occupiedHall = ticketsCount * 100.0 / capacity;
                Console.WriteLine($"{movieName} - {occupiedHall:f2}% full.");
            }
            double totalTickets = standardTicketsCount + standardTicketsCount + kidTicketsCount;
            Console.WriteLine($"Total tickets: {soldTicketsCounter}");
            double standardTicketsPercentage = standardTicketsCount * 100.0 / soldTicketsCounter;
            double studentsTicketsPercentage = studentTicketsCount * 100.0 / soldTicketsCounter;
            double kidTicketsPercentage = kidTicketsCount * 100.0 / soldTicketsCounter;
            Console.WriteLine($"{studentsTicketsPercentage:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPercentage:f2}% kids tickets.");
        }
    }
}
