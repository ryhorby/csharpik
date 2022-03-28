using csharpik.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace csharpik.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Error")]
        [Route("Home/Error/{code?}")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int? code)
        {
            if(code != null)
                ViewData["Error"] = code.ToString();

            ErrorViewModel error = new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier };
            
            return View(error); 
        }
    }
}
