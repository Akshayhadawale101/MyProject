using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loop
{
    internal class Vovelsconsonent
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Character");
            ch=char.Parse(Console.ReadLine());  
            switch (ch) 
            {
                case 'a': Console.WriteLine("is vovwls" );
                    break;
                case 'e': Console.WriteLine("is vovels");
                    break;
                case 'i': Console.WriteLine("is vovels");
                    break;
                case 'o': Console.WriteLine("is vovels");
                    break;  
                    case 'u': Console.WriteLine("is vovel");
                    break;  
                    default: Console.WriteLine("is consonent");
                    break;
            }

        }
    }
}
