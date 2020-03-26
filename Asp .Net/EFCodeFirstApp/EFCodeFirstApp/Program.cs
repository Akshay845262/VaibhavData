using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace EFCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDBContext pdb = new ProductDBContext();
            var product = pdb.Products;
           /* product.Add(new Product
            {
                ProductName = "Coffee",
                Price = 30.00
            });
            pdb.SaveChanges();*/
        }
    }
    public class ProductDBContext:DbContext
    {
        public ProductDBContext() : base("ProductDBContext")
        {
           
        }
        public DbSet<Product> Products { get; set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        
    }

}
