using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.whiledemo
{
    internal class sum1to10
    {
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    sum = sum + 1;
                }
                i++;
            }
            Console.WriteLine(sum);

        } 
    }
}
