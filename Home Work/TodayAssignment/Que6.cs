using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.TodayAssignment
{
    internal class Que6
    {
        static void Main(string[] args)
        {
            //avg of digit present in string
            string n = "hi123";
            float avg = 0,cou=0;
            string con = "";
            for (int i = 0; i < n.Length; i++)
            {
                if(n[i] >=48&& n[i] <=57)
                {
                    con = n[i].ToString();
                    int t = Convert.ToInt32(con);
                    avg += t;
                    cou++;
                }
            }
            Console.WriteLine(avg/cou);
        }
    }
}
