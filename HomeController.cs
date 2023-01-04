using KdvEklemeWebAplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KdvEklemeWebAplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(KdvEkle kdvEkle)
        {
            var fiyat = kdvEkle.Fiyat;
            var kdv_Ekle = fiyat + (fiyat * 18) / 100;
            ViewBag.Message ="KDV Eklenmesi Sonucu : " + kdv_Ekle;

            return View("kdvEkle");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}