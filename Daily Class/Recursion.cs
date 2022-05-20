using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class
{
    class Program
    {
        public static void m1(int n)
        {
            if(n>0)
            {
                Console.WriteLine(n);
                m1(n - 1);
            }
            Console.WriteLine("Recursion");
        }
        public static int Factorial(int n)
        {
            if(n==1)
                return 1;
            else
            {
                int ans=Factorial(n-1);
                return ans * n;
            }
        }
    }
    internal class Recursion
    {
        static void Main(string[] args)
        {
            // Program.m1(5);
            Console.WriteLine(Program.Factorial(3));
        }
    }
}
