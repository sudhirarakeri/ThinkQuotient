using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.ForLoop
{
    internal class Multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("a X "+i+" = "+(a*i));                
            }
        }
    }
}
