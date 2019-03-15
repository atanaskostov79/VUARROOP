using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog.countDog = 2;
            Dog d = new Dog();
            Dog a = new Dog();
            d.Name = "Sharo";
            d.SayHello();
            Console.WriteLine("Dog count " + Dog.countDog); 
            Console.ReadKey();
            //Console.WriteLine(Test.Test1.ToString());
        }
    }
}
