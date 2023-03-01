using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class Countoddnumber
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("enter number");
            for (int i = 20; i<= 50; i++)
            {
                if (i % 2 == 1)
                {
                    {
                        count++;
                    }
                    Console.WriteLine(" ");
                   // Console.ReadLine();

                }
              


            }
            Console.WriteLine(count);
        }
    }
}
