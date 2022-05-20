using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Daily_Class.CollectionConcept
{
    internal class StackAndQueue
    {
        static void Main(string[] args)
        {
            //FILO - first in last out
            Console.WriteLine("-------------Stack--------------");
            Stack s=new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);

            Console.WriteLine(s.Pop());//Pop use for remove last data
            int d =(int) s.Peek();//Peek use for only display the last data not remove
            Console.WriteLine(d);
            Console.WriteLine();

            //FIFO - first in first out
            Console.WriteLine("-------------Queue-------------");
            Queue q=new Queue();
            q.Enqueue("om");
            q.Enqueue("sai");
            q.Enqueue(90);
            q.Enqueue("ram");

            string n=q.Dequeue().ToString();
            //Console.WriteLine(n); //remove first data
            foreach(dynamic dy in q)
                Console.WriteLine(dy);
        }
    }
}
