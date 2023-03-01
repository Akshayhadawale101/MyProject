using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    internal class Threenumber
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("Enter a 3 digit number");

            n = Convert.ToInt32(Console.ReadLine());
            if (n > 99 && n < 1000)
                Console.WriteLine("The sum of 1st and 3rd digits is :" + (n / 100 + ((n % 100) / 10)));
            else Console.WriteLine("Invalid Input");
        }
    }
}
