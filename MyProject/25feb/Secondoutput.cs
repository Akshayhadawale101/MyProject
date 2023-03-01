using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._25feb
{
    internal class Secondoutput
    {
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }

    }
}

