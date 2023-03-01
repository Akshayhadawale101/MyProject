using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.whiledemo
{
    internal class palindrome
    {
        static void Main(string[] args)
        {
            int num, rem,
            sum = 0,
            temp;
            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0) 
            {
                rem= num % 10;
                num= rem / 10;
                sum = sum *10+rem;
            }
            Console.WriteLine( sum);
            if(temp==sum) 
            {
                Console.WriteLine("No.is palindrome");
            }
            else 
            {
                Console.WriteLine("No.is not Palindrome");
            }
            Console.WriteLine();
        }       
    }
}
