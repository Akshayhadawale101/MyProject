using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._25feb
{
    internal class Ten
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 2 number");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (IsPrime(num1) && IsPrime(num2) && Math.Abs(num1 - num2) == 2)
                Console.WriteLine("twin is prime!");
            else
            Console.WriteLine("not prime!");
        }

        static bool IsPrime(int n)
        {
            if (n<=1)
                return false;
            for (int i = 2; i<=n ; i++)
                if (n%i==0)
                    return true;    
            return false;
               
           
        }
            
        }
        
    }

