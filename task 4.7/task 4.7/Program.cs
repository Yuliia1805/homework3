using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! You need to enter information about three cars. And I'll compare these cars!");

            string s;
            string n;
            string m;
            int a;
            int b;
            int c;
            int d;
            int e;
            int g;


            Console.WriteLine("\n");
            Console.WriteLine("Enter marking plate of the first car: ");
            s = Console.ReadLine();
            Console.WriteLine("Enter max speed of the first car: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fuel rate of the first car: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Enter marking plate of the second car: ");
            n = Console.ReadLine();
            Console.WriteLine("Enter max speed of the second car: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fuel rate of the second car: ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Enter marking plate of the third car: ");
            m = Console.ReadLine();
            Console.WriteLine("Enter max speed of the third  car: ");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fuel rate of the third car: ");
            g = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            if (a > c)
            {
                Console.WriteLine("The first car is faster");

            }
            if (c > e)
            {
                Console.WriteLine("The second car is faster");
            }
            if (e > a) 
            {
                Console.WriteLine("The third car is faster");
            }
            if (b > d) 
            {
                Console.WriteLine("The first car is more economical");
            }
            if (d > g)
            {
                Console.WriteLine("The second car is more economical");
            }
            if (g > b)
            {
                Console.WriteLine("The third car is more economical");
            }


            Console.ReadLine();
        }
    }
}
