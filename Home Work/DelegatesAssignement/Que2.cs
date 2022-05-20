using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.DelegatesAssignement
{
    internal class Que2
    {
        public static void Isprime(int n)
        {
            int c = 0;
            for(int i = 1; i <= n; i++)
            {
                if(n%i == 0)
                    c++;
            }
            if(c == 2)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");
        }
        static void Main(string[] args)
        {
            Action<int> action = (n) => Console.WriteLine(n*n);
            action(2);
            //Action<int> a=(n) => Isprime;
        }
    }
}
