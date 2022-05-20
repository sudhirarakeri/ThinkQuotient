using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.OOPs
{
    abstract class India
    {
        abstract public void Hindi();
        abstract public void Marathi();
    }
    class Maharashtra:India
    {
        readonly int a ;
        const int b=20;//It always need to Initialize where we declare
        private protected int c = 80;
        protected internal int d = 30;
        public Maharashtra(int a)
        {
            //b = 20;
            this.a = a;
        }
        public override void Hindi()
        {
            Console.WriteLine("Hindi");
        }
        public override void Marathi()
        {
            Console.WriteLine("Marathi");
        }
        public Maharashtra()
        { }
    }
    class Mumbai : Maharashtra
    {
        public Mumbai()
        { }
        public override void Marathi()
        {
            Console.WriteLine("Marathi");
        }
        static void Main(string[] args)
        {
            Maharashtra m = new Maharashtra();
            Console.WriteLine(m.d);
            //Console.WriteLine(m.c);
        }
    }
    internal class AbstarctMethod
    {
        static void Main(string[] args)
        {
            Maharashtra m=new Maharashtra(44);//intialise only ones
            //m.a=10; can't pass value bcoz its readonly
            //m.b=20; const also run ones
            Console.WriteLine(m.d);
        }
    }
}
