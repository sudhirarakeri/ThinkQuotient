using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que20
    {
        static void Main(string[] args)
        {
            //harshad Number.
            Console.WriteLine("enter number");
            int n=Convert.ToInt32(Console.ReadLine());
            int rem = 0,result=0,m=n;
            for(int i=0;i<=m;i++)
            {
                rem = m % 10;
                result= rem + result;
                m = m / 10;
            }
            Console.WriteLine();
            if(n%result==0)
                Console.WriteLine("Harshad Number");
            else
                Console.WriteLine("Not a harshad number !");
        }
    }
}
