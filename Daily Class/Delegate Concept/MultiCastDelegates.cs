using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Delegate_Concept
{
    public delegate void mydelegate(string n);
    public class LowUppe
    {
        public void Upper(string n)
        {
            Console.WriteLine("Upper case : " + n.ToUpper());
        }
        public void Lower(string n)
        {
            Console.WriteLine("Lower case : " + n.ToLower());
        }
    }
    internal class MultiCastDelegates
    {
        static void Main(string[] args)
        {
            LowUppe lu=new LowUppe();
            
            string n = "Sudhir";
            mydelegate multi = new mydelegate(lu.Upper);
            multi += new mydelegate(lu.Lower);

            //multi -= new mydelegate(lu.Upper); // remove the reference from invocation list

            Delegate[] list=multi.GetInvocationList();
            foreach(Delegate item in list)
            {
                Console.WriteLine(item.Method);
                item.DynamicInvoke(n);
            }
        }
    }
    
}
