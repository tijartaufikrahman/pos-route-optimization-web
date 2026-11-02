using Microsoft.AspNetCore.Mvc;

namespace SistemOptimasi.Controllers
{
    public class MasterLayananController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
