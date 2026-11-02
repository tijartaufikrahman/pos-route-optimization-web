using Microsoft.AspNetCore.Mvc;

namespace SistemOptimasi.Controllers
{
    public class AuthController : Controller
    {        
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LupaPassword()
        {
            return View();
        }

        public IActionResult VerifikasiOTP()
        {
            return View();
        }
        
        public IActionResult ResetPassword()
        {
            return View();
        }
    }
}