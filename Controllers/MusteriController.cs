using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class MusteriController : Controller
    {
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

            return View(musteri);
        }
    }
}