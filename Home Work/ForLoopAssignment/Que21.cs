using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que21
    {
        static void Main(string[] args)
        {
            //all palindrome no. 100 to 500
            int n = 0 ;
            string rev = "";
            for (int i = 100; i <500; i++)
            {
                n = i;
                for(int j = 1; j <=n; j++)
                {
                    rev = rev + (n % 10);
                    n = n / 10;
                    j = 0;
                }
                string m=Convert.ToString(i);
                if(rev==m)
                    Console.WriteLine(i);
                rev = "";
            }
        }
    }
}
