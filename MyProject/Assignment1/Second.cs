using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    internal class Second
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 5 == 0 && num % 11 == 0)
                Console.WriteLine("Number is divisible by 5 and 11");
            else
                Console.WriteLine("Number is not divisible by 5 and 11");

        }

    

        }
    }

