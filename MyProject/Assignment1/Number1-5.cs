using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    internal class Number1_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dsiplay number 1 to 5");
            int num=int.Parse(Console.ReadLine());
            switch (num) 
            {
                case 1: Console.WriteLine("One");

            break;  
                    case 2: Console.WriteLine("two");
                    break;
                    case 4: Console.WriteLine("four");  
                    break;
                    case 3: Console.WriteLine("Three");
                        break; 
                case 5: Console.WriteLine("Five");
                    break;
                    default: Console.WriteLine("invalid");
                    break;
            
            }
        }
    }
}
