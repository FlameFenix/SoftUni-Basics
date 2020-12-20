using System;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedbook = Console.ReadLine();
            string currentbook = Console.ReadLine();

            bool isFound = false;

            int countcheckedbooks = 0;


            while (currentbook != "No More Books")
            {

                if (searchedbook == currentbook)
                {
                    isFound = true;
                    break;
                }

                countcheckedbooks++;

                currentbook = Console.ReadLine();
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {countcheckedbooks} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {countcheckedbooks} books.");
            }
        }
    }
}
