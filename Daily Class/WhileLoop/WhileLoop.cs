using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.WhileLoop
{
    internal class WhileLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a=Convert.ToInt32(Console.ReadLine());

            int sum = 0,n=0,b=a;
            while(b>0)
            {
                n = b % 10;
                sum = sum + n;
                b=b/10;
            }
            if(a%sum==0)
                Console.WriteLine("Harshad Number");
            else
                Console.WriteLine("Not Harshad Number");
        }
    }
    
}
