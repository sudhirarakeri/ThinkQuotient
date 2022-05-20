using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.StringMethod
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string n = new string("rodo");
            string n2 = new string("rodo");
            Console.WriteLine(Object.ReferenceEquals(n,n2));
            Console.WriteLine();
            int? i = null;

            string s = "rohan mehta is red";
            s = s.Replace("red", "pink");
            s = s.Replace('r', 'm');
            s = s.Replace('s', 'g');
            Console.WriteLine(s);
            char[] b = s.ToCharArray();
            b[0]=char.ToUpper(b[0]);
            foreach(char c in b)
                Console.WriteLine(c);
        }
    }
}
