using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.whiledemo
{
    internal class oddeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("The given number is even");
                    break;

                }

                else if (num % 2 != 0)                  {
                    Console.WriteLine("The given number is odd");                                          //break statement terminates the execution of current iteration of a loop and jumps to next iteration of same or another loop   

                }

            }
        }
    }
}
