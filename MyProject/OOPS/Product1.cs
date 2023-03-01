using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPS
{
    internal class Product1 
    {
        
        string name;
        int price;
        int quantity;
        int bill;

        public void Tbill() 
        {
        if(quantity>0)
            {

                bill = quantity * price;
                Console.WriteLine(bill);
            }
        else 
            {
                Console.WriteLine("error");
            }
        }
        
        static void Main(string[] args)
        {
            Product1 p = new Product1();
            p.name = "Abc";
            p.price = 30;
            p.quantity = 3;
            Console.WriteLine(p.name+p.price+p.quantity);
            p.Tbill();
                
            }

           
                    
            }  
        }
    

