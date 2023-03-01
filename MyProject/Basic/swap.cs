using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Basic
{
    internal class swap
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("Before num1 ={ num1}, num2 ={ num2}");
            num1 = num2;
            num2 = num1;
            Console.WriteLine("After num1={num1}, num2={num2}");
            Console.ReadLine();
        }
    }
}
