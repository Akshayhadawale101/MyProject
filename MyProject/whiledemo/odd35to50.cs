using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.whiledemo
{
    internal class odd35to50
    {
        static void Main(string[] args)
        {
            int i = 35;
            while (i <= 50)
            { 
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
             }
        }

    }
}
