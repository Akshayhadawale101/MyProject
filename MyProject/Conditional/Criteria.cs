using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Conditional
{
    internal class Criteria
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter percentage");
            int percentage=int.Parse(Console.ReadLine());
            if (year > 2021)
            {
                if (percentage >= 60)
                {
                    Console.WriteLine("Eligible for interview");
                }
                else
                {
                    Console.WriteLine("try next time");
                }
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
            

        }
    }
}
