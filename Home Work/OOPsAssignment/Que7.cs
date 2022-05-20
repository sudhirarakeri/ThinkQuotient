using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.OOPsAssignment
{
    class Calculation
    {
        public void Area(int a)
        {
            Console.WriteLine("Area of Square is "+(a*a));
        }
        public void Area(int w,int l)
        {
            Console.WriteLine("Area of Rectangle is "+(w*l));
        }
        public void Area(float pi,int r)
        {
            Console.WriteLine("Area of Circle is "+(pi*r*r));
        }
    }
    internal class Que7
    {
        static void Main(string[] args)
        {
            Calculation c=new Calculation();
            c.Area(4);
            c.Area(2,4);
            c.Area(3.14f,4);
        }
    }
}
