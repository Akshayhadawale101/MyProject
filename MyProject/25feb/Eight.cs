using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._25feb
{
    internal class Eight
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >=0 ; i++)
            {
                for (int j = 1; j <=i ; j++)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
