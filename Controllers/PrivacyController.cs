using Microsoft.AspNetCore.Mvc;

namespace csharpik.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
