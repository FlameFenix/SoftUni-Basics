using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabsCount = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int penalty = 0;
            string output = string.Empty;

            for (int i = 0; i < tabsCount; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    penalty = 150;
                    if (salary > penalty)
                    {
                        salary -= penalty;
                        output = $"{salary}";
                    }
                    else
                    {
                        output = "You have lost your salary.";
                        break;
                    }

                }
                else if (website == "Instagram")
                {
                    penalty = 100;
                    if (salary > penalty)
                    {
                        salary -= penalty;
                        output = $"{salary}";
                    }
                    else
                    {
                        output = "You have lost your salary.";
                        break;
                    }
                }
                else if (website == "Reddit")
                {
                    penalty = 50;
                    if (salary > penalty)
                    {
                        salary -= penalty;
                        output = $"{salary}";
                    }
                    else
                    {
                        output = "You have lost your salary.";
                        break;
                    }
                }
                else if (website != "Facebook" || website != "Instagram" || website != "Reddit")
                {
                    output = $"{salary}";
                }
            }
            Console.WriteLine(output);
        }
    }
}
