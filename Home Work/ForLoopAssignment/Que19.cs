using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ForLoopAssignment
{
    internal class Que19
    {
        static void Main(string[] args)
        {
            //automorphic no.
            Console.WriteLine("Enter number");
            int a=Convert.ToInt32(Console.ReadLine());
            int b = 0, n = 0 ;

            b = a * a;
            int m = a,cw=0;
            Console.WriteLine($"{a} x {a} = "+b);
            while(a>0)
            {
                int r1 = a % 10;
                a = a / 10;
                int r2 = b % 10;
                b = b / 10;
                if(r1!=r2)
                {
                    cw++;
                }
            }
            Console.WriteLine( );
            if(cw == 0)
                Console.WriteLine("Automorphic");
            else
                Console.WriteLine("Not a automorphic");

            /*for(int i = 0; i <= m; i++)
            {
                m = m / 10;
                n++;
                i = 0;
            }
            int last = 0,j = 10; ;
            for(int i = 1; i <= n; i++)
            {
                if(i==n)
                    last = b % j;
                j = j * 10;
            }*/
        }
    }
}
