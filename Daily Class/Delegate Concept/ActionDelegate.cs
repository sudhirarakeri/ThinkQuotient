using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Delegate_Concept
{
    internal class ActionDelegate
    {
        public static void pri(int a,string s)
        {
            Console.WriteLine(a+" "+s );
        }
        static void Main(string[] args)
        {
            //Action use for void method
            Action<int, string> d1 = pri;
            d1(1, "dar");
        }
    }
}
