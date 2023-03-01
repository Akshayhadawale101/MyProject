using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Conditional
{
    internal class greaterless
    {
        static void Main(string[] args)
        /*  {
              Console.WriteLine("Input a first number(<50): ");
              int m = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Input a second number(>100): ");
              int n = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine((m > 50 && n < 100));
          }*/
        { 
            Console.WriteLine("Enter The number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 50 && num <= 100)
            {
                Console.WriteLine("number is greater then 50 or less than 100");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            /*else 
            {
                Console.WriteLine("Invalid number");
             }*/
        }

    }
}