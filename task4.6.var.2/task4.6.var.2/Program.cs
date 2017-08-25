using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4._6.var._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please, enter two numbers and I wiil calculate the resul of your chosen action.");

            double a;
            double b;
            char c;

            Console.WriteLine("Enter first number: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an action: ");
            Console.WriteLine("'+' - addition");
            Console.WriteLine("'-' - subtraction");
            Console.WriteLine("'*' - multiplying");
            Console.WriteLine("'/' - division");
            Console.WriteLine("'%' - reminder of divison");
            Console.WriteLine("Enter your choice: ");
            c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case '+':
                    {
                        Console.WriteLine("You chose an addition. The result is: " + (a + b));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine("You chose a subtrtaction. The result is: " + (a - b));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine("You chose a multiplying. The result is: " + (a * b));
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine("You chose a division. The result is: " + (a / b));
                        break;
                    }
                case '%':
                    {
                        Console.WriteLine("You chose a reminder of division. The result is: " + (a % b));
                        break;
                    }
            }





            Console.ReadLine();
        }
    }
}
