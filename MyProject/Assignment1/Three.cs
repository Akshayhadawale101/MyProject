using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    internal class Three
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.WriteLine("enter 3 the number");
            num1= int.Parse(Console.ReadLine());
            num2= int.Parse(Console.ReadLine());
            num3= int.Parse(Console.ReadLine());

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine(num1+" is greater");
            }
            else if(num2>num1 && num2>num3)
            {
                Console.WriteLine(num2+" is greater" );
            }
            else
            {
                Console.WriteLine(num3+" is greater" );
            }
        }
    }
}
