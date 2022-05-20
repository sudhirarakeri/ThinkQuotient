using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.OOPs
{
    class Employee
    {
        int empId;
        string name;
        static int c;
        public Employee()
        {
            c++;
            empId = c;
        }
        public Employee(int i)
        {
            empId = i;
        }
        public Employee(string n)
        {
            name = n;
        }
        public Employee(int i,string n)
        {
            empId=i;
            name = n;
        }
        
    }
    internal class ParametrizedConstructor
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1=new Employee(101);
            Employee e2 = new Employee("Shivam");
            Employee e3 = new Employee(200,"Ram");
        }
    }
}
