using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPS
{
    internal class Product
    { 
         
         string name;
        double price;
        int quantity;
        public void AcceptDetails(string pname,double pprice,int pquantity)
        {
           
            name = pname;
            price = pprice;
            quantity = pquantity;
        }
        public void DisplayDetails()
        {
            Console.WriteLine( name+" "+price+" "+quantity);
        }
        static void Main(string[] args)
        {
            Product p = new Product();
            p.name = " Bike";
            p.price = 10000.00;
            p.quantity = 3;

            Product p1= new Product();
            p1.name = "car";
            p1.price = 20000.00;
            p1.quantity = 4;
            p.DisplayDetails();
            p1.DisplayDetails();
        }
    
    }
}
