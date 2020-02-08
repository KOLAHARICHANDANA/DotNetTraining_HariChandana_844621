using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsconcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp1 = new Employee(1, "Robert", 2, "Admin");
            Employee emp2 = new Employee(3, "Jeffry", 4, "Technical");
            emp1.ShowData();
            emp2.ShowData();
            Product prd = new Product() { ProductID = 2, ProductName = "HARICJAMDANA", Price = 500.00, Quantity = "500 ml" };
            prd.ShowData();
            Customer cr = new Customer() { CustomerID = 15, CustomerName = "chandu", CustomerCountry = "INDIA" };
            cr.ShowData();
        }
    }
    public class Employee
    {
        int empid;            //access specifier is private by default for class memebers
        string empname;
        short deptid;
        string deptname;
        public Employee()       //default constructor
        { }
        //public Employee(int eid, string ename)
        //{
        //    empid = eid;
        //    empname = ename;

        //}
        public Employee(int eid, string ename, short did, string dname)
        {
            empid = eid;
            empname = ename;
            deptid = did;
            deptname = dname;
        }
        public void ShowData()          //this is an instance method
        {
            Console.WriteLine("EmpID = {0}", empid);
            Console.WriteLine("EmpName = {0}", empname);
            Console.WriteLine("DeptID = {0}", deptid);
            Console.WriteLine("DeptName = {0}", deptname);
        }
        //access specifiers
        //private,protected,public,internal,protected internal
        //private-can only be accessed within the class where it is defined
        //protected can only be acccesed within the base and its derived class
        //public can be acccesed anywhere both within or outside of that class
        //internal can be accesed only within the current assembly of where that class is defined
        //protected internal can be accessed anywhere within the current assembly and onlywithin the derived class of that assembly
    }
    public class Product
    {
        int pid;
        //defining properties for the class
        public int ProductID
        {
            get { return pid; }
            set { pid = value; }

        }
        //automatic properties
        public string ProductName
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        public string Quantity
        {
            get;
            set;
        }
        public void ShowData()

        {
            Console.WriteLine("ProductID={0}", ProductID);
            Console.WriteLine("ProductName={0}", ProductName);

            Console.WriteLine("Price={0}", Price);
            Console.WriteLine("Quantity={0}", Quantity);
        }


    }
    public class Customer
    {
        int cid;

        public int CustomerID
        {
            get { return cid; }
            set { cid = value; }

        }
        public string CustomerName
        {
            get;
            set;
        }


        public string CustomerCountry
        {
            get;
            set;
        }

        public void ShowData()

        {
            Console.WriteLine("CustomerID={0}", CustomerID);

            Console.WriteLine("CustomerName={0}", CustomerName);


            Console.WriteLine("CustomerCountry={0}", CustomerCountry);

        }




    }
}