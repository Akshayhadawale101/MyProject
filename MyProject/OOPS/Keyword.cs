using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPS
{
    class user1
    {
        int num;
        public void Input(int num)
        {
            this.num = num;
        }
        public void Display()
        {
            Console.WriteLine(num);
        }
    }

    class user2
    {
        public void Read()
        {
            //show();
            Console.WriteLine("what you Read");
            //this.show();

        }

        public void show()
        { 
        Read();
            Console.WriteLine("plz read");
        }
    }

    class user3  
    {
        public user3()
        {
            Console.WriteLine("Default");
        }
        public user3(int x):this()
        {
            Console.WriteLine("x="+x);
        }

    }
        class keyword
        {
            static void Main(string[] args)
            {
                user1 u1 = new user1();
                u1.Input(245);
                u1.Display();

           // user2 u2 = new user2();
           // u2.Read();
           // u2.show ();

            //user3 u3 = new user3(50);


            }
        }
    
}