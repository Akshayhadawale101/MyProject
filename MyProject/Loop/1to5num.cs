using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class _1to5num
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter number 1 to 5");
            int num = int.Parse("Console.Readline()");
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Number Not Valid");
                    break;

            }
        }
    }
}
