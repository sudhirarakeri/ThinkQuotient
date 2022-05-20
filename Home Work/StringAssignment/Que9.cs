using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.StringAssignment
{
    internal class Que9
    {
        static void Main(string[] args)
        {
            //word can be formed from given characters in  sentence.
            string n = "THE SKY IS THE LIMIT";
            string s = "sit";
            n =n.ToLower();
            s=s.ToLower();
            string[] ns = n.Split(" ");
            bool b = false;

            for(int i = 0; i < ns.Length; i++)
            {
                if (ns[i].EndsWith(s.Substring(1)))
                    b = true;
            }
            if (b == true)
                Console.WriteLine("Yes can be formed");
            else
                Console.WriteLine("No");
        }
    }
}
