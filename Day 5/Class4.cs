using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Class4
    {
        static public int Freq(string s,char ch)
        {
            int c = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i]==ch)
                    c++;
            }
            return c;
        }
        static void Main(string[] args)
        {
            string s = "amitabh";
            string search = "mma";
            bool Isfound = true;
            foreach(char c in search)
            {
                int ori=Freq(s,c);
                int sea=Freq(search,c);
                if(ori<sea)
                {
                    Isfound = false;
                    break;
                }
            }
            if(Isfound)
                Console.WriteLine("string can be formed");
            else
                Console.WriteLine("not");
        }
    }
}
