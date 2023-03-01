using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyProject.Basic
{
    internal class Cube
    {
        static void Main(string[] args)
        {
            int k, count;
            Console.Write("\n\n");
            Console.Write("print the cube number:\n");
            Console.Write("\n\n");
            Console.Write("enter numnber");
            count=Convert.ToInt32(Console.ReadLine());
            for (k=1; k<=count; k++)
            {
                Console.Write("Cube is:(1)\n", k,(k*k*k));
            }
        }
    }
}
