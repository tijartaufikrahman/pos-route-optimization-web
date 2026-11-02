using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SistemOptimasi.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            
            ViewBag.UserId = Request.Cookies["userId"] ?? "0";
            ViewBag.Token = Request.Cookies["token"] ?? "";
            ViewBag.UserName = Request.Cookies["nama"] ?? "Guest";
            ViewBag.UserName = Request.Cookies["username"] ?? "Guest";
            ViewBag.UserRole = Request.Cookies["role"] ?? "";

            base.OnActionExecuting(context);
        }
    }
}