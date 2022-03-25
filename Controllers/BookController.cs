using Microsoft.AspNetCore.Mvc;

namespace csharpik.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
