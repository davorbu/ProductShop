using Microsoft.AspNetCore.Mvc;
using ProductShop.Models;

namespace ProductShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(string slugLink)
        {
            Product product = DataBase.GetProduct(slugLink);
            return View(product);
        }

        public IActionResult List()
        {
            List<Product> products = DataBase.GetProducts();
            return View(products);
        }
    }
}
