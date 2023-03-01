using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Basic
{
    internal class Area
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = pi * (radius * radius);
            Console.WriteLine(area);


        }
    }
}
