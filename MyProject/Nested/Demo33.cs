using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Nested
{
    internal class Demo33   
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=3;i++) 
            {
            for(int j=1;j<=3;j++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
