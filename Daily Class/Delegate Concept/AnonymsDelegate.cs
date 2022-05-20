using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Delegate_Concept
{
    internal class AnonymsDelegate
    {
        public delegate int newdele(int a,int b, int c);
        static void Main(string[] args)
        {
            Action<int, int> del = delegate (int a, int b)
               {
                   Console.WriteLine(a + b);
               };
            del(2, 4);
            Action<int, int> del2 = (a, b) => Console.WriteLine(a+b);
            del2(2, 4);
            newdele d1 = (a, b, c) =>
              {
                  Console.WriteLine("in Lymda");
                  int sum = a + b + c;
                  return sum;
              };
            
            Console.WriteLine(d1(1, 2, 3));

            newdele d2 = (a, b, c) => a + b + c; 
            Console.WriteLine( d2(1, 1, 1));
        }
    }
}
