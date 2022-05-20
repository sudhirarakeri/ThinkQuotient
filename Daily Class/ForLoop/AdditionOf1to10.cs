using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.ForLoop
{
    internal class AdditionOf1to10
    {
        static void Main(string[] args)
        {
            int tot = 0;
            for (int i = 1; i <= 10; i++)
            {
                tot=tot+i;
                Console.WriteLine(tot);
            }

        }
    }
}
