using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPS
{
    
    /*
        int id;
        string name;
        float mark;
        public void AcceptDetails(int sid, string sname, float smark)
        {
            id = sid;
            name = sname;
            mark = smark;
        }
        public void DisplayDetails()
        {
            Console.WriteLine(id + " " + name + " " + mark);
        }
        static void Main(string[] args)
        {
            Subject S = new Subject();
            S.AcceptDetails(1, "Abc", 87.5f);
            S.DisplayDetails();
        }*/

       
            class Student
    { 
            int id;
        string name;
        int m1,m2,m3;
        int percent;

        public void Accept(int sid,string sname,int mk1,int mk2,int mk3)
        {
            id = sid;
            name = sname;
            m1 = mk1;
            m2 = mk2;
            m3 = mk3;
        }

        public void CalculatePercentage()
        {
            percent = ((m1 + m2 + m3) * 100) / 300;

        }
        public void Display()
        {
            Console.WriteLine("id\t name\t m1\t m2\t m3\t ppercentage");
            Console.WriteLine(id+" "+name+" "+m1+" "+m2+" "+m3+" "+percent);

        }
        static void Main(string[] args)
        {
            Student s=new Student();
            s.Accept(1, "Akshay", 45, 56, 53);
            s.CalculatePercentage();
            s.Display();
        }
        }
    }

