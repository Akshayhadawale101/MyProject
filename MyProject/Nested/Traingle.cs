using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Nested
{
    internal class Traingle
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number of rows :");
            // int rows = Convert.ToInt32(Console.ReadLine());
            int num = 5;
            int i, j;
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                    //Console.Write();
                }

                Console.WriteLine();


            }
        }
    }
}
