using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POCO;
using Services;
using Specification;
namespace ECommerceWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            IProductService productService = new ProductService();
            List<Product> products = productService.GetAll("D:\\Ecommerce\\ECommerceWeb\\File\\products.dat");
            return View(products);
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Insert()
        {
            return View();
        }
        public ActionResult Update() {
        return View();
        }
        public ActionResult Delete()
        {
            return View();
        }


    }
}