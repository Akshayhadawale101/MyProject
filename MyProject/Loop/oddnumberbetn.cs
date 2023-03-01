using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class oddnumberbetn
    {
        static void Main(string[] args)
        {
            for (int i = 35; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

