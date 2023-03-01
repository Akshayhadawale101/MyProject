using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class tableinput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            for( int i=1; i<=10; i++)
            {
                Console.WriteLine(num*i);
            }
        }
            
    }
}
