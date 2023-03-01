using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    internal class Nine
    {
        static void Main(string[] args)
        {
            int amount, i = 0, j = 0, k = 0, l = 0, m = 0, n = 0;
            Console.WriteLine("Enter the Amount");
            amount = Convert.ToInt32(Console.ReadLine());
            if (amount >= 2000)
            {
                i++;
            }
            else if (amount >= 1000 && amount < 2000)
            {
                j++;
            }
            else if (amount >= 500 && amount < 1000)
            {
                k++;
            }
            else if (amount >= 200 && amount < 500)
            { 
                l++;
            }
            else if (amount >= 100 && amount < 200)
            {
                m++;
            }
            else if (amount >= 50 && amount < 100)
            {
                n++;
            }
            else
            {
                n--;
            }
            Console.WriteLine("2000 Denomination: " +i);
            Console.WriteLine("1000 Denomination: " +j);
            Console .WriteLine("500 Denomination: " + k);
            Console .WriteLine("200 Denomination: " + l);
            Console .WriteLine("100 Denomination: " + m);  
            Console .WriteLine("100 Denomination: " + n);  

        }
    }
}
