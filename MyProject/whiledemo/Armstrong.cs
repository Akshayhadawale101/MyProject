using MyProject.Loop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.whiledemo
{
    internal class Armstrong
    {
        static void Main(string[] args)
        {
            int n, r,
            sum = 0,
            temp;
            Console.WriteLine("Enter Number");
           // Console.ReadLine(( ));
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r*r*r);
                n = n / 10;
            }
            if (temp == sum)
            
                Console.WriteLine("Armstrong Number");
            
            else
            
                Console.WriteLine("Not Armstrong");
            
        }
    } 

}
