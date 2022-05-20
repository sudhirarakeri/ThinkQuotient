using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.OOPs
{
    class Chain
    {
        int no,price;
        string name;
        float per;
        public Chain():this(56,67)
        {
            Console.WriteLine("1st constructor");
        }
        public Chain(int no,int price)
        {
            this.no = no;
            this.price = price;
            Console.WriteLine("2nd constructor");
        }
        public Chain(int no,int price,string name,float per):this(no,price)
        {
            this.name = name;
            this.per = per;
            Console.WriteLine("3rd constructor");
        }
    }
    internal class ConstructorChaining
    {
        static void Main(string[] args)
        {
            Chain c=new Chain();
            Console.WriteLine();
            Chain c1=new Chain(78,56,"h",78.9f);

        }
    }
}
