using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Conditional
{
    internal class Divisible39
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 3 == 0 || num % 9 == 0)
            {

                if (num % 3 == 0)
                {
                    Console.WriteLine("Number is divisible by 3");
                }
               /* else
                {
                    Console.WriteLine("Not Divisible by 3");
                }*/
            }
            else if (num % 9 == 0)
            {
                Console.WriteLine("Number is Divisible by 9");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 3 or  9");
            }

        }

    }

        
    
}
