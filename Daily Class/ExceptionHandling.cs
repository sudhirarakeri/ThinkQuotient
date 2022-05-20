using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class
{
    public class InvalidMobileException:ApplicationException
    {
        public InvalidMobileException(string m):base(m)
        {

        }
        public override string ToString()
        {
            return "errorrrrrrrr";
        }
    }
    internal class ExceptionHandling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a no.");
            long n = long.Parse(Console.ReadLine());
            
            if (n.ToString().Length == 10)
                Console.WriteLine("valid number!");
            else
            {
                try
                {
                    throw new InvalidMobileException("invalid number or not a 10 digit");
                }
                catch (InvalidMobileException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e);
                }
            }
        }
    }
}
