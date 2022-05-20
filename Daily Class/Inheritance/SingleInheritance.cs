using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Inheritance
{
    class Parent1
    {
        public Parent1()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child1:Parent1
    {
        public Child1()
        {
            Console.WriteLine("Parent Child");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-----Single Inheritance-----");
            Child1 c1=new Child1();
        }
    }
}
