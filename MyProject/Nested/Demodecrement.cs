using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Nested
{
    internal class Demodecrement
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=4; i++)
            {
                for (int j = 4; j >=i; j--)
                {
                  //  Console.Write("*");
                  Console.Write(j);//4321.432.43.4
                    //Console.Write(i);//1111.222.33.4
                }
                Console.WriteLine();
            }
        }
    }
}
