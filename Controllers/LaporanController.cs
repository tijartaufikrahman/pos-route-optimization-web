using Microsoft.AspNetCore.Mvc;

namespace SistemOptimasi.Controllers
{
    public class LaporanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
