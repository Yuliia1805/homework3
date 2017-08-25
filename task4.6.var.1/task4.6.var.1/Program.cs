using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4._6.var._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            Console.WriteLine("Hi! I am your simple calculator! Please, enter two numbers and choose necessary action");

            //declaring variables
            double a;
            double b;
            char c;

            Console.Write("Enter the first number: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            b = int.Parse(Console.ReadLine());

            //Choice of action
            Console.WriteLine("Choose your action: ");
            Console.WriteLine("'+' - addition");
            Console.WriteLine("'-' - subtraction");
            Console.WriteLine("'*' - multiplying");
            Console.WriteLine("'/' - division");
            Console.WriteLine("'%' - reminder of division");
            Console.WriteLine("Enter your choice: ");

            c = char.Parse(Console.ReadLine());

            //Calculating
            if (c == '+')
            {
                Console.WriteLine("You chose addition. The result is: " + (a + b));
            }
            if (c == '-')
            {
                Console.WriteLine("You chose subtraction. The result is: " + (a - b));
            }
            if (c == '*')
            {
                Console.WriteLine("You chose multiplying. The result is: " + (a * b));
            }
            if (c == '/')
            {
                Console.WriteLine("You chose division. The result is: " + (a / b));
            }
            if (c == '%')
            {
                Console.WriteLine("You chose reminder of division. The result is: " + (a % b));
            }
            else if (c != '+' && c != '-' && c != '*' && c != '/' && c != '%')
            {
                Console.WriteLine("You chose incorrect option");
            }
        




            Console.ReadLine();

        }
    }
}
