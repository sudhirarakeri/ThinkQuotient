using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Inheritance
{
    class Bus
    {
        private protected int a = 10;
        protected internal int b = 20;
        public virtual void Travel()
        {
            Console.WriteLine("Travel By bus");
        }
        public void Capacity()
        {
            Console.WriteLine("50 Capcity of bus");
        }
        static public /*virtual*/ void Line()
        {
            Console.WriteLine("in bus line");
        }
        public virtual void Speed()
        {
            Console.WriteLine("at 80 speed of bus");
        }
        /*sealed*/ static public void Plate()
        {
            Console.WriteLine("");
        }
    }
    /*sealed*/ class Car:Bus
    {
        public override void Travel()
        {
            Console.WriteLine("Travel By car");
        }
        public void Capacity()
        {
            Console.WriteLine("5 Capcity of car");
        }
        static public /*override*/ void Line()
        {
            Console.WriteLine("in car line");
        }
        public /*sealed*/ override void Speed()
        {
            Console.WriteLine("at 120 speed of car");
        }
    }
    class Bike : Car
    {
        public override void Speed()
        {
            Console.WriteLine("at 30 speed of bike");
        }
        public override string ToString()
        {
            return "hi";//in case we want to print object references
        }
    }
    internal class assignement1
    {
        static void Main(string[] args)
        {
            Bike b = new Bike();
            Console.WriteLine(b);
        }
    }
}
