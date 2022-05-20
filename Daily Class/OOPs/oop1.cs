using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.OOPs
{
    class Calculator
    {
        public void Add(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum = "+sum);
            Console.WriteLine();
        }
        public float SimpleInterest(int p,float r,int n)
        {
            float si = p * r * n;
            return si;
        }
        public bool IsLeapYear(int y)
        {
            if(y%4==0)
                return true;
            else
                return false;
        }
    }
    internal class OOP1
    {
        static void Main(string[] args)
        {
            Calculator c=new Calculator();
            Console.WriteLine("Enter Two Number = ");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            c.Add(a,b);
            Console.WriteLine("Enter Simple Interest value = ");
            Console.Write("P =");
            int p=Convert.ToInt32(Console.ReadLine());
            Console.Write("R =");
            float r=Convert.ToSingle(Console.ReadLine());
            Console.Write("T =");
            int t=Convert.ToInt32(Console.ReadLine());
            float r1=c.SimpleInterest(p,r,t);
            Console.WriteLine(r1);
            Console.WriteLine();
            Console.WriteLine("Enter Year ");
            int y=Convert.ToInt32(Console.ReadLine());
            bool y3=c.IsLeapYear(y);
            Console.WriteLine(y3);
        }
    }
}
