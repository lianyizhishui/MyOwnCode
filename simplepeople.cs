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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            People yang = new People("yang",20);
            yang.ShowInfo();
            Console.ReadKey();

        }
    }
}
