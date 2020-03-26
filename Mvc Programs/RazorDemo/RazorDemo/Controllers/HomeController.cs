using RazorDemo.Models;
using System.Web.Mvc;

namespace RazorDemo.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product()
        {
            ProductID = 1,
            Name = "Product Name 1",
            Description = "Product 1 description",
            Category = "Product 1 category",
            Price = 275M

        };
        /*Product newProd = new Product
        {
            ProductID = 2,
            Name = "Product Name 2",
            Description = "Product 2 description",
            Category = "Product 2 category",
            Price = 475M
        };*/

        // GET: Home
        public ActionResult Index()
        {
            return View(myProduct);
        }
        public ActionResult NameandPrice()
        {
            return View(myProduct);
        }
        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 0;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;
            return View(myProduct);
        }
        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product {Name ="Product1",Price=275M},
                new Product {Name ="Product2",Price=48.95M},
                new Product {Name ="Product3",Price=19.50M},
                new Product {Name ="Product4",Price=34.95M},
            };
            return View(array);
        }
    }
}