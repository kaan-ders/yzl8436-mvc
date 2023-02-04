using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        //action, endpoint
        public IActionResult Index()
        {
            var cnt = HttpContext;

            return View();
        }
    }
}