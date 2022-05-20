using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Inheritance.Trainer
{
    class HourlyBaseTeacher:Teacher
    {
        int hr;
        int payment;
        public HourlyBaseTeacher()
        {
            Console.WriteLine("Hourly base Teacher");
        }

        public int Hr { get => hr; set => hr = value; }
        public int Payment { get => payment; set => payment = value; }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Teacher t=new Teacher();
            Permanentteacher p=new Permanentteacher("ram","java",15,8000);
            HourlyBaseTeacher h=new HourlyBaseTeacher();
            h.Tname = "varun";
            h.Subject = "c#";
            h.Experiance = 10;
            h.Payment = 5670;
            h.Hr = 30;
            
        }
    }
}
