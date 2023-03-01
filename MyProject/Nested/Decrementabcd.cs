using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Nested
{
    internal class Decrementabcd
    {
        static void Main(string[] args)
        {
            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);//ABCD.ABC.AB.A

                }
                Console.WriteLine();
            }
        }
    }
}
