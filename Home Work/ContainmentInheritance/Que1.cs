using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ContainmentInheritance
{
    class Teacher
    {
        int tid;
        string tname;
        long tmobile;

        public Teacher(int tid, string tname, long tmobile)
        {
            this.tid = tid;
            this.tname = tname;
            this.tmobile = tmobile;
        }
    }
    class Hourlybased:Teacher
    {
        int rate_per_hr;
	    int hrs;

        public Hourlybased(int tid, string tname, long tmobile, int rate_per_hr, int hrs ) :base(tid,tname,tmobile)
        {
            this.rate_per_hr = rate_per_hr;
            this.hrs = hrs;
        }

        public void Salary()
        {
            Console.WriteLine("in HourlyBased ");
        }
    }
    class SalaryBased:Teacher
    {
        int salary;
        public SalaryBased( int tid, string tname, long tmobile, int salary) : base(tid, tname, tmobile)
        {
            this.salary = salary;
        }
        public void Salary()
        {
            Console.WriteLine("in SalryBased ");
        }
    }
    internal class Que1
    {
        static void Main(string[] args)
        {
            Hourlybased h = new Hourlybased(1,"Praful",9876543212,1000,20);
            h.Salary();
            SalaryBased s = new SalaryBased(2, "Ganesh", 9837662512, 20000);
            s.Salary();
        }
    }
}
