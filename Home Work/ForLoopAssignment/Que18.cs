using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que18
    {
        static void Main(string[] args)
        {
            //palindrome
            Console.WriteLine("Enter number");
            int n=Convert.ToInt32(Console.ReadLine());
            int k=n;
            string rev = "";
            for(int i=0;i<=k;i++)
            {
                rev =rev+( k % 10);
                k = k / 10;
                i = 0;
            }
            string m = Convert.ToString(n);
            Console.WriteLine("Reverse = "+rev);
            Console.WriteLine();
            if (m == rev)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
        }
    }
}
