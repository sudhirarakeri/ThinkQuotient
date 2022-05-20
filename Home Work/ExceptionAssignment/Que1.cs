using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ExceptionAssignment
{
    internal class Que1
    {
        static void Main(string[] args)
        {
            string n;
            try
            {
                Console.WriteLine("enter");
                n=Console.ReadLine();
                Console.WriteLine("right bro "+n);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Null value");
            }
        }
    }
}
