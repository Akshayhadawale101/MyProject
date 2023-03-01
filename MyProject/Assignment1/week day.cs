using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignment1
{
    internal class week_day
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day number 1 to 7");
            int num = int.Parse(Console.ReadLine());

            switch (num) 
            {
                case 1: Console.WriteLine(" Mon");
                    break;
                    case 2: Console.WriteLine("Tue");
                    break;
                    case 3: Console.WriteLine("Wed");
                    break;
                    case 4: Console.WriteLine("Thu");
                    break;
                    case 5: Console.WriteLine("Fri");
                    break;
                        
                    case 6: Console.WriteLine("Sat");
                    break;
                    case 7: Console.WriteLine("Sun");
                    break;
                    default: Console.WriteLine("Invalid");
                    break; 

            
            }
        }
    }
}
