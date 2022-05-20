using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ExceptionAssignment
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            string n = "hello";
            try
            {
                int a=Convert.ToInt32(Console.ReadLine());
                int b=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a / b);
                for(int i = 0; i < n.Length; i++)
                    Console.WriteLine(n[i+1]);
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("index is out of range");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("divide by zero is not posiible");
            }
        }
    }
}
