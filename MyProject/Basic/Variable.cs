using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Basic
{
    internal class Variable
    {
        static void Main(string[] args)
        {
            byte mybyte= 56;//1 bytes 8 bits//127 to 128 
            sbyte mybyte2 =-67;//7 bit value 1 bit for sign

            short mynuml = 678;//2 bytes //32768 to -32767
            short mynum2 = -567;


             int myinttype = 50000; //4 bytes//2^31 to 2 -31

            int myint= -890000;

            long my1= 987768899099;// 8 bytes//2^64 to 2"-64

            long my12= -532673293842984;

            float per2=67.44f;//4 bytes

            double per= 78.56;//8 bytes s

            char ch = 't';
            char ch2 = '3';
            char ch3 = '#';


            bool ischeck =true;
            Console.WriteLine(ischeck);

            string myname = "Akshay";
            Console.WriteLine(myname);
        }
    }
}
