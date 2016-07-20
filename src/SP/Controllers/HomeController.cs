using Microsoft.AspNetCore.Mvc;

namespace SP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
