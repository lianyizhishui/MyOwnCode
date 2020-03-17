using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplepeople
{
    class People {
        private string name;
        private int age;
        public People(string name,int age) {
            this.name = name;
            this.age = age;
        }
        public People() : this("", -1) { }
        public People(string name) {
            this.name = name;
        }
       public People(int age) {
            this.age = age;

        }
        public void ShowInfo() {
            System.Console.WriteLine($"{name} is {age} years old");

        }
        public void SayHello() {
            Console.WriteLine("hello" + name);
        }
        public void SayHello(People another) {
            Console.WriteLine("hello" + another.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {      
            People yang = new People("yang",20);
            People anotherPeople = new People("another", 20);
            yang.SayHello();
            yang.SayHello(anotherPeople);
            Console.ReadKey();
        }
    }
}
