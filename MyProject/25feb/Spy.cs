using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject._25feb
{
    internal class Spy
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number");
            
            int num = Convert.ToInt32(Console.ReadLine());

            int digit, sum = 0;
            int orgNum = num;
            int prod = 1;

            while (num > 0)
            {
                digit = num % 10;

                sum += digit;
                prod *= digit;
                num /= 10;
            }

            if (sum == prod)
                Console.WriteLine (orgNum + " is Spy Number");
        else
                Console.WriteLine (orgNum + " is not Spy Number");

        }
    }
}
