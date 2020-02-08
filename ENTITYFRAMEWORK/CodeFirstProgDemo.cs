using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace CodeFirstProgDemo
{
    class Program
    {
        static void Main(string[] args)
        {

        }
      
      
        
    }
    public class CustomerDBContext : CustomerDBContext
    {
        public CustomerDBContext() : base("name=CustomerDBContext")
        { }
        public DbSet<Customer> Customers { get; set; }
    }
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public IList<Order> Orders { get; set; }

    }
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public DateTime ShippedDate { get; set; }
    }
}
