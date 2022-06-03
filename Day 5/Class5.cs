using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Department
    {
        int id;
        string name;
        string location;
        static int count = 0;

        public Department(string name, string location="Pune")//Default parameter
        {
            id= ++count;
            this.name = name;
            this.location = location;
        }

        public override string ToString()
        {
            return $"Id {id} \nName {name} \nLocation {location}\n";
        }

        public static void TotalCount() => Console.WriteLine($"Total Count is : {count}");
    }
    internal class Class5
    {
        static void Main(string[] args)
        {
            /*Department d = new Department(1,"sudhir");//Optional Parameter
            Department d2 = new Department(location:"Pimpri",id:2,name:"harshad");*/

            Department d1 = new Department("vijay");
            Department d2 = new Department("kiran", "pimpri");
            Department d3 = new Department("ketan", "delhi");
            Department d4 = new Department("ravi", "kolkata");
            Console.WriteLine(d1+"\n"+d2+"\n"+d3+"\n"+d4);
            Department.TotalCount();
        }
    }
}
