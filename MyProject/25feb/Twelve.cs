using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._25feb
{
    internal class Twelve
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number:");
            for (int i = 1; i <=50; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i+"("+(i*i)+")");
                }
                Console.ReadLine();
            }
        }
    }
}
