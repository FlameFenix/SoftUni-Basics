using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0;
            string output = string.Empty;

            if (operation == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    output = $"{num1} {operation} {num2} = {result} - even";
                }
                else
                {
                    output = $"{num1} {operation} {num2} = {result} - odd";
                }
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    output = $"{num1} {operation} {num2} = {result} - even";
                }
                else
                {
                    output = $"{num1} {operation} {num2} = {result} - odd";
                }
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    output = $"{num1} {operation} {num2} = {result} - even";
                }
                else
                {
                    output = $"{num1} {operation} {num2} = {result} - odd";
                }
            }
            else if (operation == "/")
            {
                result = num1 / num2;
                if (num2 == 0)
                {
                    output = $"Cannot divide {num1} by zero";
                }
                else
                {
                    output = $"{num1} / {num2} = {result:f2}";
                }
            }
            else if (operation == "%")
            {
                result = num1 % num2;
                if (num2 == 0)
                {
                    output = $"Cannot divide {num1} by zero";
                }
                else
                {
                    output = $"{num1} % {num2} = {result}";
                }

            }

            Console.WriteLine(output);
        }
    }
}
