using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class oddevenswitch
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the Number");
             num = Convert.ToInt32(Console.ReadLine());


            switch (num % 2)
            {
                 
               
            case 0: Console.WriteLine(num + " is even number");
                break;
 
                
            case 1: Console.WriteLine(num + " is odd number");
                break;
            }

            Console.ReadLine();

        }

    }
        
    
}
