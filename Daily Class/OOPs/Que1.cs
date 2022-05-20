using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.OOPs
{
    class Sudhir
    {
        public void M1()
        {
            Console.WriteLine("in M1");
            M2();
        }
        public void M2()
        {
            Console.WriteLine("in M2");
            M3();
        }
        public static void M3()
        {
            Console.WriteLine("in M3");
            M4();
        }
        public static void M4()
        {
            Console.WriteLine("in M4");
           // M1(); bcoz static have no object
        }
    }
    internal class Que1
    {
        static void Main(string[] args)
        {
            Sudhir s=new Sudhir();
            s.M1();
            Sudhir.M3();
        }
    }
}
