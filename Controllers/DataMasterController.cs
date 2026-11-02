using Microsoft.AspNetCore.Mvc;

namespace SistemOptimasi.Controllers
{
    public class DataMasterController : BaseController
    {
        public IActionResult Users()
        {
            // ViewBag otomatis terisi dari BaseController
            return View();
        }

        public IActionResult LokasiKantor()
        {
            
            return View();
        }
        public IActionResult Roles()
        {            
            return View();
        }

        public IActionResult ProofOfDelivery()
        {
            return View();
        }
    }
}