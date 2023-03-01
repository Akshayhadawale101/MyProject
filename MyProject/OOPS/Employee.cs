using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPS
{
     class Employee
    {
        int id;
        String name;
        int salary;
        static void Main(string[] args)
        {
            Employee emp;
            emp= new Employee();

            emp.id= 1;
            emp.name = "Akshay";
            emp.salary = 15000;
            Console.WriteLine(emp.id+emp.name+emp.salary);
        }

    }
}
