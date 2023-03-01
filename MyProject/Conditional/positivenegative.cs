using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Conditional
{
    internal class positivenegative
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("n\n");
            Console.Write("input an integer:");
            num= Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
                Console.WriteLine("{0} Is positive number.\n", num);
            else 
                Console.WriteLine("{0} is negative.\n",num); 
        }
        
    }
}
