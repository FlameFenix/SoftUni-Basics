using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsSum = 0;
            int finalSum = 0;
            string output = string.Empty;
            string output2 = string.Empty;
            while (stepsSum < 10000)
            {
                string command = Console.ReadLine();
                if (command == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    stepsSum += stepsToHome;
                    if (stepsSum < 10000)
                    {
                        finalSum = 10000 - stepsSum;
                        output = $"{finalSum} more steps to reach goal.";
                    }
                    else if (stepsSum > 10000)
                    {
                        finalSum = stepsSum - 10000;
                        output = "Goal reached! Good job!";
                        output2 = $"{finalSum} steps over the goal!";

                    }
                    break;
                }

                int steps = int.Parse(command);

                if (command != "Going home")
                {
                    stepsSum += steps;
                }
            }
            if (stepsSum < 10000)
            {
                finalSum = 10000 - stepsSum;
                output = $"{finalSum} more steps to reach goal.";
            }
            else if (stepsSum > 10000)
            {
                finalSum = stepsSum - 10000;
                output = "Goal reached! Good job!";
                output2 = $"{finalSum} steps over the goal!";

            }
            Console.WriteLine(output);
            Console.WriteLine(output2);
        }
    }
}
