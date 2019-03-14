using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat(-3);
            cat2.color = "Gray";
            cat1.color = "Black";
            
           // Console.WriteLine( Math.Cos(45f));
            cat1.SayMiau();
            cat1.color = "White";
            cat1.SayMiau();
            cat2.SayMiau();
            Console.ReadKey();
        }
    }
}
