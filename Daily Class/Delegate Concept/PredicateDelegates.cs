using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Delegate_Concept
{
    internal class PredicateDelegates
    {
        public static bool iseven(int n)
        {
            if(n%2==0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            //Predicate use for Bool Value
            Predicate<int> d1 = iseven;
            bool b = d1(2);
            Console.WriteLine(b);
        }
    }
}
