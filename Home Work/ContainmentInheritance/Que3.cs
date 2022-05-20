using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ContainmentInheritance
{
    class Person
    {
        int id;
        string name;
        public Person(int id, string name, Vehicle v)
        {
            this.id = id;  
            this.name = name;
            Console.WriteLine("Person Id is "+id);
            Console.WriteLine("Person name is "+name);
        }
    }
    class Vehicle
    {
        int vid;
        string name;
        public Vehicle(int vid, string vname)
        {
            this.vid = vid;
            this.name = vname;
            Console.WriteLine("Vehicle Id is "+vid); 
            Console.WriteLine("Vehicle name is "+vname); 
        }
    }
    internal class Que3
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle(354467,"swift");
            Vehicle v2 = new Vehicle(865673,"hexa");
            Console.WriteLine();
            Person p = new Person(1,"yogesh",v);
            Person p2 = new Person(2,"rama",v2);
        }
    }
}
