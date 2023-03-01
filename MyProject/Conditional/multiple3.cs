using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyProject.Conditional
{
    internal class multiple3
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num*3==0) 
            {
                Console.WriteLine("number is multiple by 3");
            }
            else
            {
                Console.WriteLine( " Not multiple by 3");
            }

        }
    }
}
