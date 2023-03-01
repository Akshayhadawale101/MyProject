using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Nested
{
    internal class Borderabcd
    {
        static void Main(string[] args)
        {
            
           
            for ( char i = 'D'; i >= 'A'; i--)
            {
                for ( char j = 'A'; j <= 'D'; j++)
                {
                    if ( i=='A' || j=='D'|| (i!=j && i!='C' || j!='B'))
                       
                        Console.Write(j);
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
