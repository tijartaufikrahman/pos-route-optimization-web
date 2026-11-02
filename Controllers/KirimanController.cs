using Microsoft.AspNetCore.Mvc;

namespace SistemOptimasi.Controllers
{
    public class KirimanController : Controller
    {
        public IActionResult Index()
        {
            return View("Kiriman");
        }

        public IActionResult Detail(string tanggal)
        {
            ViewBag.Tanggal = tanggal;
            return View("DetailKiriman");
        }
    }
}
