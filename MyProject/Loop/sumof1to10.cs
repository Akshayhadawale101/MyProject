using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class sumof1to10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum 1 to 10 number");
            int sum = 0;
            for (int i=1;i<=10;i++)
            {
                sum += i;
            }
            Console.WriteLine("sum is:"+sum);
        }
    }
}
