
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment2
{
    internal class even
    {
        static void Main(string[] args)
        {
            for (int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
