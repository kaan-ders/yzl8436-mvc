using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using MvcApp.Servis;

namespace MvcApp.Controllers
{
    public class MusteriController : Controller
    {
        private IDatabase _database;

        public MusteriController(IDatabase database)
        {
            _database = database;
        }

        private List<Musteri> Musteriler = new List<Musteri>
        {
            new Musteri
            {
                Id = 1,
                Adi = "Ahmet",
                Ulke = "Almanya",
                SiparisSayisi = 10
            },
            new Musteri
            {
                Id = 2,
                Adi = "Ayşe",
                Ulke = "Amerika",
                SiparisSayisi = 5
            }
        };

        //action - sayfa
        public IActionResult Index()
        {
            return View(Musteriler);
        }

        //action - sayfa
        public IActionResult Detay(int id)
        {
            Musteri musteri = null;

            foreach (var item in Musteriler)
            {
                if (item.Id == id)
                {
                    musteri = item;
                    break;
                }
            }

            ViewData["ToplamStok"] = 600;
            //key - value -> dictionary, hashtable

            return View(musteri);
        }
    }
}