using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Inheritance
{
    class GrandFather
    {
        public GrandFather()
        {
            Console.WriteLine("Grand Father");
        }
    }
     class Parent : GrandFather
    {
        public Parent()
        {
            Console.WriteLine("GrandFather Parent ");
        }
        public void M1()
        {
            Console.WriteLine("M1 ");
        }
        public void M2()
        {
            Console.WriteLine("M2");
        }
    }
    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Parent Child");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-----Multilevel Inheritance-----");
            Child c = new Child();
            c.M1();
            c.M2();
        }
    }
}
