using Microsoft.AspNetCore.Mvc;

namespace SistemOptimasi.Controllers
{
    public class PenugasanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PenugasanPengantaran()
        {
            return View();
        }

        public IActionResult RiwayatPenugasan()
        {
            return View();
        }

        public IActionResult TambahPenugasan()
        {
            return View();
        }

        public IActionResult DetailPenugasan()
        {
            return View();
        }

        public IActionResult OptimasiPengantaran()
        {
            return View();
        }

        public IActionResult OptimasiPengantaran2()
        {
            ViewData["DetailOptimasiUrl"] = "/Penugasan/DetailOptimasi2";
            return View("OptimasiPengantaran");
        }

        public IActionResult DetailOptimasi()
        {
            return View();
        }

        public IActionResult DetailOptimasi2()
        {
            ViewData["ModeRingkas"] = true;
            return View("DetailOptimasi");
        }

        public IActionResult TestingRute()
        {
            return View();
        }

        public IActionResult RutePengantaran()
        {
            return View();
        }
    }
}
