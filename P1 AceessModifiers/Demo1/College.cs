using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AceessModifiers.Demo1
{
    public class College
    {
        string clname;
        public College()
        {
            Console.WriteLine("in College");
        }

        public string Clname { get => clname; set => clname = value; }
    }
}
