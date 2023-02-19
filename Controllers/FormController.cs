using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using System.Collections;

namespace MvcApp.Controllers
{
    public class FormController : Controller
    {



        private List<FormModel> models = new List<FormModel>
        {
            new FormModel
            {
                Adresi = "gljsdkjs sfklsdjfsdjfk",
                KayitTarihi = DateTime.Now.AddMonths(-1),
                MusteriAdi = "Mehmet Kaplan",
                SiparisSayisi = 5
            },
            new FormModel
            {
                Adresi = "sflkasnfklda ajsdfjaslıdja alsdjalsjdlas",
                KayitTarihi = DateTime.Now.AddMonths(-2),
                MusteriAdi = "Ayşe Kaplan",
                SiparisSayisi = 28
            }
        };

        public IActionResult Index(int id)
        {
            return View(models[id]);
        }

        public IActionResult Liste()
        {
            return View(models);
        }

        //get- > gösterme
        public IActionResult Ekle()
        {
            List<Ulke> ulkeler = new List<Ulke>
            {
                new Ulke
                {
                    Adi = "Türkiye"
                },
                new Ulke
                {
                    Adi = "Almanya"
                },
                new Ulke
                {
                    Adi = "Amerika"
                }
            };

            //ViewData["Ulkeler"] = ulkeler;

            ViewBag.Ulkeler = ulkeler;

            /*ArrayList list = new ArrayList();
            list.Add("Ahmet");
            list.Add(12);
            list.Add(new Ulke());

            int sayi1 = Convert.ToInt32(list[1]) + 10;*/

            return View();
        }

        //post -> kaydetme
        [HttpPost]
        public IActionResult Ekle(FormModel model)
        {
            //FormModel model = new FormModel
            //{
            //    MusteriAdi = HttpContext.Request.Form["adi"],
            //    Adresi = HttpContext.Request.Form["adresi"],
            //    KayitTarihi = DateTime.Parse(HttpContext.Request.Form["tarihi"]),
            //    SiparisSayisi = Convert.ToInt32(HttpContext.Request.Form["sayi"])
            //};

            //modeli dbye yaz

            models.Add(model);
            return View();
        }

        //get -> gösterme
        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            return View(models[id]);
        }

        //post -> Kaydetme
        [HttpPost]
        public IActionResult Guncelle(FormModel model)
        {
            //dbye kaydet
            return View();
        }
    }
}