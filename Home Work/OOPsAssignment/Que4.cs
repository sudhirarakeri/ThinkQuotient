using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.OOPsAssignment
{
    class Account1
    {
        public long Account_No;
        public string Customer_Name;

        public Account1()
        {
            Account_No = 343248732648;
            Customer_Name = "Sudhir Arakeri";
            Console.WriteLine("I am in default Constructor");
        }
        public Account1(long accno,string cusname)
        {
            Account_No= accno;
            Customer_Name= cusname;
            Console.WriteLine("I am in parameterized Constructor");
        }
    }
    internal class Que4
    {
        static void Main(string[] args)
        {
            Account1 a1= new Account1();
            Account1 a2= new Account1(390222334,"suraj");
        }
    }
}
