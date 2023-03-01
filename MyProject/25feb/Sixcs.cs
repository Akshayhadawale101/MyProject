using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._25feb
{
    internal class Sixcs
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=4 ; i++)
            {
                for (int j = 4-1; j >=1; j--)
                {
                    Console.WriteLine(" ");
                }
                for (int j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write(i);
                }
                    Console.WriteLine(" ");
                
            }
        }
    }
}
