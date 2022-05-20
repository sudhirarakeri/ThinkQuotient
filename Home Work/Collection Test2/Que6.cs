using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.Collection_Test2
{
    internal class Que6
    {
        static void Main(string[] args)
        {
            Stack s=new Stack();
            s.Push("RRR");
            s.Push("KGF");
            s.Push("Mari");
            s.Push("RED");

            foreach(var item in s)
                Console.WriteLine(item);
        }
    }
}
