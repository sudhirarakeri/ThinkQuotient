using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Class.Containment
{
    class Flat
    {
        int flatno;
        string buildingname;
        Owner onr=new Owner();

        public Flat(int flatno, string buildingname)
        {
            this.flatno = flatno;
            this.buildingname = buildingname;
        }
        public Flat()
        {

        }
        public int Flatno { get { return flatno; } set { flatno = value; } }
        public string Buildingname { get { return buildingname; } set { buildingname = value;} }
        public Owner Onr { get { return onr; } set { onr = value; } }

    }
    class Owner
    {
        string Ownername;
        int age;
        long phoneNo;
        char gender;
        public Owner()
        { }
        public Owner(string ownername, int age, long phoneNo, char gender)
        {
            Ownername = ownername;
            this.age = age;
            this.phoneNo = phoneNo;
            this.gender = gender;
        }

        public string Ownername1 { get => Ownername; set => Ownername = value; }
        public int Age { get => age; set => age = value; }
        public long PhoneNo { get => phoneNo; set => phoneNo = value; }
        public char Gender { get => gender; set => gender = value; }
    }
    internal class Containment1
    {
        static void Main(string[] args)
        {
            Flat f=new Flat();
            Console.Write("Enter Flat no. = ");
            f.Flatno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Building Name = ");
            f.Buildingname = Console.ReadLine();
            Console.Write("Enter Owner Name = ");
            f.Onr.Ownername1 = Console.ReadLine();
            Console.Write("Enter Age = ");
            f.Onr.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone no. = ");
            f.Onr.PhoneNo = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Gender = ");
            f.Onr.Gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Flat No. is \'{f.Flatno}\'");
            Console.WriteLine($"Building Name is \'{f.Buildingname}\'");
            Console.WriteLine($"Owner Name is \'{f.Onr.Ownername1}\'");
            Console.WriteLine($"Owner Age is \'{f.Onr.Age}\'");
            Console.WriteLine($"Phone number is \'{f.Onr.PhoneNo}\'");
            Console.WriteLine($"Gender is \'{f.Onr.Gender}\'");

        }
    }
}
