using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Daily_Class.CollectionConcept
{
    internal class LinkedListMethod
    {
        static void Main(string[] args)
        {
            LinkedList<int> l=new LinkedList<int>();
            l.AddFirst(1);
            l.AddFirst(2);
            l.AddFirst(3);
            l.AddLast(4);
            l.AddLast(5);
            l.Find(3);
            LinkedListNode<int> nodeafter=l.Find(3);
            l.AddAfter(nodeafter, 4000);
            l.AddBefore(nodeafter, 2000);

            foreach(int i in l)
                Console.WriteLine(i);

            Console.WriteLine();

            LinkedList<string> list=new LinkedList<string>();
            list.AddFirst("ram");
            list.AddLast("hanuman");

            LinkedListNode<string> node = list.Find("sugriv");
            
            if(node!=null)
            {
                list.AddAfter(node, "laxman");
                list.AddBefore(node, "siya");
            }
            else
                Console.WriteLine("Node is null");

            foreach(string i in list)
                Console.WriteLine(i);
        }
    }
}
