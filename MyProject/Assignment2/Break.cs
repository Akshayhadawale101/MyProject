using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment2
{
    internal class Break
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {

                if (i == 4)
                {
                    break;
                }

                Console.WriteLine();

            }
        }
    }
}
