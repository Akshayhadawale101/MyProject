using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Basic
{
    internal class Percentage
    {
        static void Main(string[] args)
        {

            int marks1, marks2, marks3, marks4, marks5 ;
            int total;
            float percentage;
          

            Console.WriteLine("Enter the marks subject 1: ");
            marks1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks subject 2: ");
            marks2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks subject 3: ");
            marks3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks subject 4: ");
            marks4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks subject 5: ");
            marks5 = int.Parse(Console.ReadLine());

            total = marks1 + marks2 + marks3 + marks4 + marks5;
            Console.WriteLine(total);

            percentage = (total /5) * 100;
            Console.WriteLine(percentage);

          
        }
    }
}
