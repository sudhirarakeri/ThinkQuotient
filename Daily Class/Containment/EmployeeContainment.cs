using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Containment
{
    class Employee
    {
        int empid;
        string empname;
        int salary;
        Deptartment dept=new Deptartment();

        public int Empid { get => empid; set => empid = value; }
        public string Empname { get => empname; set => empname = value; }
        public int Salary { get => salary; set => salary = value; }
        public Deptartment Dept { get => dept; set => dept = value; }
    }
    class Deptartment
    {
        int deptid;
        string deptname,manager;

        public int Deptid { get { return deptid; } set { deptid = value; } }
        public string Deptname { get { return deptname; } set { deptname = value; } }
        public string Manager { 
            get 
            { 
                return manager; 
            } 
            set 
            { 
                manager = value;
            }
        }
    }
    internal class EmployeeContainment
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Empid = 101;
            e.Empname = "ravi";
            e.Salary = 30000;
            e.Dept.Deptid = 1;
            e.Dept.Deptname = "IT";
            e.Dept.Manager = "xyz";
        }
    }
}
