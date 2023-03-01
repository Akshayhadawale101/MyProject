using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.whiledemo
{
    internal class Countodd20to50
    {

        static void Main(string[] args)
        {
            int i=20;
            int count = 0;
            while(i<=50)
            {
                if (i % 2!=0)
                {
                    {
                        count++;
                    }
                    Console.WriteLine("  ");
                }
               
            }
            Console.WriteLine(count);
        }
    }
}
