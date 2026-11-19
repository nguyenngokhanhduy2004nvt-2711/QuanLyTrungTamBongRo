using Microsoft.AspNetCore.Mvc;

namespace NguyenNgoKhanhDuy_DH52200571.Controllers
{
    public class CoachController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserRole") != "HLV")
            {
                return RedirectToAction("Login", "DangNhap");
            }

            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            return View();
        }
    }
}