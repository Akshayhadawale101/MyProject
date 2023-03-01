using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Conditional
{
    internal class Alphabetdigit
    {
        static void Main(string[] args)
        {
            char ch;
          // int num;

            Console.WriteLine("Enter Any Character ");
            ch = Convert.ToChar(Console.ReadLine());


            // num = Convert.ToInt32(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("is an Alphabet. ");
            }
          /*  else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("is a Digit. ");
            }*/
            else
            {
                Console.WriteLine( " Special character.. ");
            }

            Console.ReadLine();


        }

    }
}
