using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work.ContainmentAssignment
{
    class Order
    {
        int orderId;
        string orderDate;
        Customer c=new Customer();
        Item i=new Item();

        public int OrderId { get => orderId; set => orderId = value; }
        public string OrderDate { get => orderDate; set => orderDate = value; }
        public Customer C { get { return c; } set { c = value; } }
        public Item I { get { return i; } set { i = value; } }  
    }
    class Customer
    {
        string custName;
        long phoneNo;
        Address addr=new Address();

        public string CustName { get => custName; set => custName = value; }
        public long PhoneNo { get => phoneNo; set => phoneNo = value; }
        internal Address Addr { get => addr; set => addr = value; }
    }
    class Address
    {
        string custAddres;
        string state;
        int pinCode;

        public string CustAddres { get => custAddres; set => custAddres = value; }
        public string State { get => state; set => state = value; }
        public int PinCode { get => pinCode; set => pinCode = value; }
    }
    class Item
    {
        int itemId;
        string itemName;
        int itemPrice;

        public int ItemId { get { return itemId; } set { itemId = value; } }
        public string ItemName { get { return itemName; } set { itemName = value; } }
        public int ItemPrice { get { return itemPrice; } set { itemPrice = value; } }
    }
    internal class Que1
    {
        static void Main(string[] args)
        {
            Order o=new Order();
            Console.Write("Order Id = ");
            o.OrderId =Convert.ToInt32(Console.ReadLine());
            Console.Write("Order Date = ");
            o.OrderDate = Console.ReadLine();
            Console.Write("Customer Name = ");
            o.C.CustName = Console.ReadLine();
            Console.Write("Customer Phone No. = ");
            o.C.PhoneNo=Convert.ToInt64(Console.ReadLine());
            Console.Write("Customer Address = ");
            o.C.Addr.CustAddres = Console.ReadLine();
            Console.Write("State = ");
            o.C.Addr.State = Console.ReadLine();
            Console.Write("Pincode = ");
            o.C.Addr.PinCode =Convert.ToInt32(Console.ReadLine());
            Console.Write("Item Id = ");
            o.I.ItemId= Convert.ToInt32(Console.ReadLine());
            Console.Write("Item Name = ");
            o.I.ItemName= Console.ReadLine();
            Console.Write("Item Price = ");
            o.I.ItemPrice= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Order Id is {o.OrderId}");
            Console.WriteLine($"Order Date is {o.OrderDate}");
            Console.WriteLine($"Customer Name is {o.OrderDate}");
            Console.WriteLine($"Customer Phone No. is {o.C.CustName}");
            Console.WriteLine($"Customer Address is {o.C.PhoneNo}");
            Console.WriteLine($"State is {o.C.Addr.CustAddres}");
            Console.WriteLine($"Pincode is {o.C.Addr.PinCode}");
            Console.WriteLine($"Item Id is {o.I.ItemId}");
            Console.WriteLine($"Item Name is {o.I.ItemName}");
            Console.WriteLine($"Item Price is {o.I.ItemPrice} Rs.");
        }
    }
}
