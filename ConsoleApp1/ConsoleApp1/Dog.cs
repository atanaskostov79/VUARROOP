using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Dog
    {
        //Statini poleta
        public static int countDog = 0; 
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
            Dog.countDog++;

            this.age = 1;

            Point p = new Point(1, 2);
            Console.WriteLine( "Piont " + p.X );

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

    //static class Test
    //{
    //    public static string Test1()
    //    {

    //        //Console.WriteLine();
    //        return "static class";
    //    }
    //}
}
