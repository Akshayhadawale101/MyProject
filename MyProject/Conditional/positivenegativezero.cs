using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Conditional
{
    internal class positivenegativezero
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Enter number is positive ");
            }
            else if (num < 0)
            {
                Console.WriteLine("Enter number is nagative ");
            }
            else
            {
                Console.WriteLine("Enter number is zero ");
            }

            Console.ReadLine();
        }
    }
}
