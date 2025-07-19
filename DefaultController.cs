using Microsoft.AspNetCore.Mvc;

namespace Project_OOP.Controllers
{
    public class DefaultController : Controller
    {
        void messages() // geriye değer döndürmeyen metot örnegi
        {
            ViewBag.m1 = "Merhaba bu bir Core Projesi";
            ViewBag.m2 = "Proje çok iyi gidiyor";
            ViewBag.m3 = "Bu kursu sevdim.";
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }
        int cevre()
        {
            int kisa = 30;
            int uzun = 50;
            int cvr = 2 * (kisa + uzun);
            return cvr;
        }
        public IActionResult Index()
        {
            messages();
            return View();
        }
        public IActionResult Urunler()
        {

            messages();
            ViewBag.t = topla(); // void türünde olsaydı hata verirdi.
            ViewBag.c = cevre();
            return View();
        }
    }
}
