using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog
    {
        // Poleta
        private string name;
        private string poroda;
        private int age;
        // Svoistva ( Properties )
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Poroda { get; set; }

        public Dog()
        {
            Console.WriteLine( "Hello I'm Dog");
            this.age = 1;
        }
        public void SayHello()
        {
            Console.WriteLine( " My name is {0} Age : {1}", 
                this.Name, this.age );
        }

        private int dogAge()
        {

            return  (this.age - 1) * 7;
        }
    }
}
