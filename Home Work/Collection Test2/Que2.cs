using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.Collection_Test2
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            Queue q=new Queue();
            q.Enqueue("Red");
            q.Enqueue("Pink");
            q.Enqueue("Green");
            q.Enqueue("Yellow");
            q.Enqueue("Violet");

            foreach (var item in q)
                Console.WriteLine(item);
        }
    }
}
