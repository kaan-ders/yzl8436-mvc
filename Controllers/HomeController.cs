using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using MvcApp.Servis;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        private IDatabase _database;

        public HomeController(IDatabase database)
        {
            _database = database;
        }

        //action, endpoint
        public IActionResult Index(string id)
        {
            //var cnt = HttpContext;
            Isim isim = new Isim { Adi = id };

            _database.Ekle(isim);
            return View(isim);
        }
    }
}