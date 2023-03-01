using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.whiledemo
{
    internal class Dispplay1to5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 5");
            int num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                switch (num)
                {

                    case 1: Console.WriteLine("One");
                        break;
                    case 2: Console.WriteLine("Two");
                        break;
                    case 3: Console.WriteLine("Three");
                        break;
                    case 4: Console.WriteLine("Four"); 
                        break;
                    case 5: Console.WriteLine("Five");
                        break;
                    default:
                        Console.WriteLine("Number Not Valid");
                        break;

                }

                  

            }

        }

    }
}
    

