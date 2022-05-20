using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P1_AceessModifiers.Demo1;

namespace P1_AceessModifiers.Demo2
{
    public class ClassofClg
    {
        string cname;
        College c = new College();
        public ClassofClg()
        {            
            Console.WriteLine("in Class");
        }
        public string Cname { get { return cname; } set { cname = value; } }

        public College C { get => c; set => c = value; }

        static void Main(string[] args)
        {
            College c = new College();
        }
    }
}
