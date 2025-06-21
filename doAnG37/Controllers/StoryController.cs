using Microsoft.AspNetCore.Mvc;

namespace doAnG37.Controllers
{
    public class StoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
