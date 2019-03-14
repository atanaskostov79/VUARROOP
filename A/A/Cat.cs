using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Cat
    {
        public string color;
        public string name;

        private int age;

        public Cat()
        {
            this.name = "Garfild";
            
        }
        public Cat( int age )
        {
            this.age = Math.Abs(age);
            Console.WriteLine("Age {0} , {1}", age, this.age);
        }

        public void SayMiau()
        {
            string color = "red";
            Console.WriteLine("Miau. I'm {0} . my name is {1} ", this.color, this.name);
        }
    }
}
