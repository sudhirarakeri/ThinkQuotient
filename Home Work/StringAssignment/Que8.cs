using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.StringAssignment
{
    internal class Que8
    {
        static void Main(string[] args)
        {
            //print common characters between them in alphabetical order
            string n1 = "thin sticks";
            string n2 = "thick bricks";
            char[] c1=n1.ToCharArray();
            char[] c2=n2.ToCharArray();

            string com = "";
            int c = 0;
            for (int i = 0; i < c1.Length; i++)
            {
                for (int j = 0; j < c2.Length; j++)
                {
                    if (c1[i] == c2[j] && c1[i] != ' ')
                    {
                        c++;
                        break;
                    }
                }
                if (c != 0)
                    com += c1[i];
                c = 0;
            }
            string common = "";
            for (int i = 0; i < com.Length; i++)
            {
                for (int j = 0; j < com.Length; j++)
                {
                    if (com[i] == com[j] && j < i)
                        break;
                    else if (com[i] == com[j])
                        c++;
                }
                if (c != 0)
                    common += com[i];
                c = 0;
            }
            char[] result = common.ToCharArray();
            Array.Sort(result);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
