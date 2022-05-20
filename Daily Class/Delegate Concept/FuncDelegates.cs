using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Delegate_Concept
{
    internal class FuncDelegates
    {
        public static string add(int a,string b)
            { return $" {a} name {b} "; }
        static void Main(string[] args)
        {
            //Func return a value or datatype method and also for bool
            Func<int, string, string> d1 = add;
            string s = d1(1, "sudhir");
            Console.WriteLine(s);
        }
    }
}
