using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace codefirstdemoprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDBContext context = new ProductDBContext();
            LinqToEntity();
            var product = context.Products;

            var product1 = product.Add(new Product() { ProductID = 1, Name = "frooti", Price = 99.99, Quantity = "500 ml", CategoryID = 1 });
            var product2 = product.Add(new Product() { ProductID = 2, Name = "mazza", Price = 59.99, Quantity = "200 ml", CategoryID = 1 });
            var product3 = product.Add(new Product() { ProductID = 1, Name = "coke", Price = 89.99, Quantity = "300 ml", CategoryID = 1 });
            var categories = context.categories;
            var category1 = categories.Add(new Category() { CategoryID = 1, Name = "beverages" });
            context.SaveChanges();

        }
        public static void LinqToEntity()
        {

            ProductDBContext context = new ProductDBContext();

            var EconProducts = from product in context.Products
                               where product.Price < 90.00
                               select product;
            foreach(var product in EconProducts)
            {
                Console.WriteLine("ProductID:{0},Name:{1},Price:{2}", product.ProductID, product.Name, product.Price);
            }
            
        }
    }
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() :
            base("name=ProductDBContext")
        { }
        public DbSet <Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }

    }

    public class Product
    {
        public int ProductID { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
        public int CategoryID { get; set; }
    }
    public class  Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
