using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.Collection_Test2
{
    internal class Que4
    {
        static void Main(string[] args)
        {
            SortedList<int, string> l = new SortedList<int, string>();
            l.Add(1, "siya");
            l.Add(2, "ken");
            l.Add(3, "ram");
            l.Add(4, "diya");

            foreach(var d in l)
                Console.WriteLine(d);
        }
    }
}
