using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ContainmentInheritance
{
    class Volume
    {
        double v;
        public double volume(double r)
        {
            v = (4 / 3) * (22 / 7) * (r * r * r);
            return v;
        }
        public double volume(double h, double r)
        {
            v = (22 / 7) * (r*r) * h;
            return v;
        }
        public double volume(double l, double b, double h)
        {
            v = l * b * h;
            return v;
        }
    }
    internal class Que4
    {
        static void Main(string[] args)
        {
            Volume v=new Volume();
            double s1=v.volume(1.5);
            double s2=v.volume(34,45.6);
            double s3=v.volume(4,45.6,76);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
