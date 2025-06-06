using Microsoft.AspNetCore.Mvc;

namespace doAnG37.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}
