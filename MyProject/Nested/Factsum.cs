using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Nested
{
    internal class Factsum
    {
        static void Main(string[] args)
        {
            int fact = 1, sum = 0;
            Console.WriteLine("Num\t"+"fact\t"+"sum");
            for(int i=1;i<=5;i++) 
            {
                fact *= i;
                sum += fact;
                Console.WriteLine(i+"\t"+fact+"\t"+sum);
            }
        }
    }
}
