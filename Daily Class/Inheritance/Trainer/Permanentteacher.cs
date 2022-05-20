using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Inheritance.Trainer
{
    class Permanentteacher:Teacher
    {
        int sal;
        public Permanentteacher()
        {
            Console.WriteLine("Permanent teacher");
        }

        public Permanentteacher(string tname, string subject, int experiance,int sal):base(tname,subject,experiance)
        {
            this.sal = sal;
        }
    }
}
