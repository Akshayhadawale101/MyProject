using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Nested
{
    internal class Demodecment    
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >=1; i--) 
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(j);//1234.123.12.1
                }
                Console.WriteLine();
            }
        }
    }
}
