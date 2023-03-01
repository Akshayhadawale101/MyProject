using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment2
{
    internal class GcdLcm
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            int gcd, lcm;

            if (a > b)
                gcd = a;
            else gcd = b;
            while (gcd != 1) ;
        }
    }
}
