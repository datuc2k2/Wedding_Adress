using Microsoft.AspNetCore.Mvc;

namespace wedding_address_c_.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
    }
}
