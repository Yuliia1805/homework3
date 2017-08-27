using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int num = 15;

             while (num < 10)
             {

                 Console.WriteLine(num++);
                 //num++;
             }*/

            /* do
             {
                 Console.WriteLine(num++);
             } while (num < 10);*/

            /*for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(j + " ");
                }
                   
                Console.WriteLine(i);
            }*/


            /*char symb = 'a';
            for (int i  = 0; i < 1000; i++)
            {
                Console.Write('a');
            }*/

            /*int a = 0;
            while (true)
            {
                Console.WriteLine(a);
                a++;
                if (a == 10)
                {
                    break;
                }
            }*/

            /* bool b = true; 
             do
             {
                 Console.WriteLine("Enter two numbers (first should be less than second)");
                 Console.Write("Enter first number: ");
                 int first = int.Parse(Console.ReadLine());
                 Console.Write("Enter second number: ");
                 int second = int.Parse(Console.ReadLine());

                 if (first < second)
                 {
                     Console.Write("Even number between {0} and {1} is: ", first, second);
                     for (int i = first; i < second; i++)
                     {
                         if (i % 2 == 0)
                         {
                             Console.Write(i + " ");
                         }
                     }
                     b = false;
                 }
                 else
                 {
                     Console.WriteLine("first number must be less than second");
                 }

             } while (b);*/

            int n = 100;
            int summ = 0;
            summ += n;



            for (int i = 1; i <= summ; i++)
                summ += i;
                
                
            {
                Console.WriteLine(summ);
            }






            



            Console.ReadLine();
        }
    }
}
