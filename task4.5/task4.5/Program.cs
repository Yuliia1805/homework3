using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 500;
            int c;

            Console.Write("Enter new price: ");
            c = int.Parse(Console.ReadLine());

            if (c > b)
            {
                Console.WriteLine("The price is higher than 500");

            } else if (c < a)

            {
                Console.WriteLine("The price is lower than 100");

            } 

            Console.ReadLine();
        }
    }
}
