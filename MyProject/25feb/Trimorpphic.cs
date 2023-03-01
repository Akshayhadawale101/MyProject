using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._25feb
{
    internal class Trimorpphic
    {
        static void Main(string[] args)
        {
           // int n;
            Console.WriteLine("Enter an integer: "); 
            int num = Convert.ToInt32(Console.ReadLine());
            int cube = num*num*num;
            while (num > 0)
            {
             
                if (num % 10 != cube % 10)

                    Console.WriteLine("Not Trimorphic");
                else
                    Console.WriteLine("Triomorphic");
                num /= 10;
                cube /= 10;
            }


        }

    }

    }



    

