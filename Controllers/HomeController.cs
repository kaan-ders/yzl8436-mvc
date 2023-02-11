using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        //action, endpoint
        public IActionResult Index(string id)
        {
            //var cnt = HttpContext;
            Isim isim = new Isim { Adi = id };
            return View(isim);
        }
    }
}