using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Home_Work.Collection_Test2
{
    internal class Que5
    {
        static void Main(string[] args)
        {
            Dictionary<string,float> map = new Dictionary<string,float>();
            map.Add("python", 23.4f);
            map.Add("c", 53.4f);
            map.Add("java", 13.4f);
            map.Add("vb", 03.4f);

            foreach(var s in map)
                Console.WriteLine(s);
        }
    }
}
