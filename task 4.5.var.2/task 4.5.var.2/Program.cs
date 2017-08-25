using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4._5.var._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 500;
            int c;

            Console.WriteLine("Enter new price: ");
            c = int.Parse(Console.ReadLine());

            if (c > b)
            {
                if (c < a)
                {
                    Console.WriteLine("The price is higher than 500");
        
                } else
                {
                    Console.WriteLine("the price is lower than 100");
                }
            }


            Console.ReadLine();
        }
    }
}
