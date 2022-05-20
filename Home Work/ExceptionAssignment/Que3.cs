using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ExceptionAssignment
{
    class IsOutOfBoundException:ApplicationException
    {
        public IsOutOfBoundException(string m):base(m)
        { }
        public override string ToString()
        {
            return "flase value";
        }
    }
    internal class Que3
    {
        static void Main(string[] args)
        {
            string n = "hie";
            try
            {
                if (n.Length == 2)
                    Console.WriteLine("correct");
                else
                    throw new IsOutOfBoundException("string is Out of Bound");
            }
            catch (IsOutOfBoundException ob)
            {
                Console.WriteLine(ob.Message);
                Console.WriteLine(ob);
            }
        }
    }
}
