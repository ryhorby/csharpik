using Microsoft.AspNetCore.Mvc;

namespace csharpik.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
