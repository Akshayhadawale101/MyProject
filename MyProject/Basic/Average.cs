
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Basic
{
    internal class Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 1st number: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("2nd number: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(" 3rd number: ");
            double c = double.Parse(Console.ReadLine());

            double average = (a + b + c) / 3;
            Console.WriteLine("average sum is: {0:F5}", average);

        }
    }
}
