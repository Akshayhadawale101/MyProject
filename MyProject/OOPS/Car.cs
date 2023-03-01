using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPS
{
     class Car
    {
         int model ;
        string name; 
        string type;
            static void Main(string[] args)
        {
            Car cr;
            cr = new Car();


            cr.model  = 11;
            cr.name = "hhh";
            cr.type = "sedan";
            Console.WriteLine(cr.model+cr.name+cr.type);


            cr.model = 111;
            cr.name = "AAA";
            cr.type = "Suv";
            Console.WriteLine(cr.model + cr.name + cr.type);


            cr.model = 1212;
            cr.name = "BBB";
            cr.type = "mpv";
            Console.WriteLine( cr.model + cr.name + cr.type);
        }
    }
}
