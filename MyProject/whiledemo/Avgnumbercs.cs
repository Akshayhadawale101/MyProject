using MyProject.Loop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.whiledemo
{
    internal class Avgnumbercs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num=int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            int Avg;
            while (num > 0) 
            {
            int digit=num%10;
               sum= sum+digit;
                num = num/10;
                count++;    

            }
            Avg = sum / count;
            Console.WriteLine("Avg is=" + Avg);
        }
    }
}
