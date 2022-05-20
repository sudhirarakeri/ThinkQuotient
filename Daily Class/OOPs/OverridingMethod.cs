using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.OOPs
{
    class Parent
    {
        public void play()
        {
            Console.WriteLine("Playing now - Parent");
        }
        public virtual void study()
        {
            Console.WriteLine("Studying now - Parent");
        }
    }
    class Child:Parent
    {
        public void play()
        {
            Console.WriteLine("Playing now - Child");
        }
        public override void study()
        {
            Console.WriteLine("Studying now - Child");
        }
        static void Main(string[] args)
        {
            Child c=new Child();
            c.study();
            Parent pp=new Parent();
            pp.study();
            Console.WriteLine("-------------------");
            Parent p=new Child();
            p.study();//this is override
            p.play();
        }
    }
}
