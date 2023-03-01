using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Nested
{
    internal class Numberincrese
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=4; i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    //Console.WriteLine("*");   
                   // Console.Write(i);//1.22.333.4444
                    Console.Write(j);//1.12.123.1234
                }
                Console.WriteLine();
            }
        }

    }
}
