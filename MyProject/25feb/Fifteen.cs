using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._25feb
{
    internal class Fifteen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num= Convert.ToInt32(Console.ReadLine());
            int fact = 1, sum = 0;
            Console.WriteLine("Number\t"+"fact\t"+"sum\t");
            for (int i = 1; i <=num; i++)

            {
                fact *= i;
                sum += fact;
                Console.WriteLine(i+"\t"+fact+"\t"+sum);
            }
        }
    }
}
