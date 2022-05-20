using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.OOPs
{
    internal class SettterGetterMethod
    {
        long Adharcard;
        string VoterName;
        string VoterCasted;

        public void SetAdharcard(long adhar)
        {
            Adharcard = adhar;
        }
        public long GetAdharcard()
        {
            return Adharcard;
        }
        public void SetVoterName(string votname)
        {
            VoterName = votname;
        }
        public string GetVoterName()
        {
            return VoterName;
        }
        public void SetVoterCasted(string votcast)
        {
            VoterCasted= votcast;
        }
        public string GetVoterCasted()
        {
            return VoterCasted;
        }
    }
    class Solution
    {
        static void Main(string[] args)
        {
            SettterGetterMethod n=new SettterGetterMethod();
            n.SetAdharcard(32487236487);
            n.SetVoterName("suraj");
            n.SetVoterCasted("BJP");
            long adhar=n.GetAdharcard();
            Console.WriteLine(adhar);
            Console.WriteLine(n.GetVoterName());
            Console.WriteLine(n.GetVoterCasted());
        }
    }
}
