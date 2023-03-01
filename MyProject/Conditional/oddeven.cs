using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyProject.Conditional
{
    internal class oddeven
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter number");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0) 
            {
                Console.Write("Enter number is even");
               // Console.Read();
            }
            else 
            {
                Console.Write("enter number is odd");
                Console.Read();
            }
        }
    }
}
