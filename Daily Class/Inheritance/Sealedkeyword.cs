using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Inheritance
{
    class Paren
    {
        public void k()
        {
            Console.WriteLine("Parent");
        }
        public virtual void m1()
        {
            Console.WriteLine("Parent");
        }
    }
    /*sealed class Chil:Paren
    {
        public sealed override void m1()
        {
            //it stop the override bcoz sealed word
        }
    }*/
    class Chil : Paren
    {
        public void k()
        {
            //Reimplementation or Hiding method
            Console.WriteLine("Child");
        }
        public override void m1()
        {
            //override the method by using virtual and override word
            Console.WriteLine("Child");
        }
    }
    class Subchil : Chil
    {
        public void k()
        {
            Console.WriteLine("Subchlid");
        }
        public override void m1()
        {
            Console.WriteLine("Subchild");
        }
    }
    internal class Sealedkeyword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paren p = new Paren();");
            Paren p = new Paren();
            p.m1();
            p.k();

            Console.WriteLine("Chil ch = new Chil();");
            Chil ch = new Chil();
            ch.m1();
            ch.k();

            Console.WriteLine("Subchil subch = new Subchil();");
            Subchil subch = new Subchil();
            subch.m1();
            subch.k();

            Console.WriteLine("Paren p2 = new Chil();");
            Paren p2 = new Chil();
            p2.m1();
            p2.k();

            Console.WriteLine("Chil cs = new Subchil();");
            Chil cs = new Subchil();
            cs.m1();
            cs.k();

            Console.WriteLine("Paren cs2 = new Subchil();");
            Paren cs2 = new Subchil();
            cs2.m1();
            cs2.k();
        }
    }
}
