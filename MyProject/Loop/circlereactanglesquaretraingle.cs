using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class circlereactanglesquaretraingle
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter First number");
            // int num1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //int num2=int.Parse(Console.ReadLine());
            int num,l,b,s,b1,height;
            float r;

            Console.WriteLine("1.circle 2.reactngle 3.square 4.traingle");
            Console.WriteLine("enter the shape");
            
           num= int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("radius:");
                    r=float.Parse(Console.ReadLine());
                    Console.WriteLine("Area of circle:"+3.14*r*r);
                    break;
                    case 2:
                    Console.WriteLine("Enter the value of l and b:");
                    l=int.Parse(Console.ReadLine());
                    b=int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of reactangle:" + (l * b));
                    break; 
                case 3:
                      Console.WriteLine("Enter the side value:");
                    s=int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of square:"+(s*s));
                    break;  
                    case 4:
                    Console.WriteLine("Enter the value h and b");
                    height=int.Parse(Console.ReadLine());
                    b1=int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of traingel:" + (height * b1) / 2);
                    break;



            }


        }
    }
}
