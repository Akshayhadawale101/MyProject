using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Nested
{
    internal class Border
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (i == 1 || j == 1 || i == row || j == row)
                    {
                        Console.Write("*");
                    }
                    else
                    {

                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }
        }
    }
}
