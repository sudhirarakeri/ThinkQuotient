using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Delegate_Concept
{
    internal class DelegatesMethod
    {
        public static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            return fact;
        }
        public delegate int myDelegate(int x);
        static void Main(string[] args)
        {
            myDelegate m = Factorial;
            Console.WriteLine(m(5));
        }
    }
}
