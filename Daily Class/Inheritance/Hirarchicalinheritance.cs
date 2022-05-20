using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Inheritance
{
    class Father
    {
        public Father()
        {
            
            Console.WriteLine("Father");
        }
    }
    class Son:Father
    {
        public Son()
        {
            Console.WriteLine("Father Son");
        }
    }
    class Daughter:Father
    {
        public Daughter()
        {
            Console.WriteLine("Father Daughter");
        }
    }
    internal class Hirarchicalinheritance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Hirarchical-----");
            Son s=new Son();
            Daughter d=new Daughter();
        }
    }
}
