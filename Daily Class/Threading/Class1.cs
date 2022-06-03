using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Daily_Class.Threading
{
    internal class Class1
    {
        public static void m1()
        {
            for(int i = 0; i < 10; i++)
                Console.WriteLine("m1 "+i);
            Console.WriteLine("Threads end");
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main Thread";
            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine("thread start");
            Thread th = new Thread(m1);
            th.Start();

            for (int i = 0; i < 5; i++)
                Console.WriteLine("main " + i);
        }
    }
}
