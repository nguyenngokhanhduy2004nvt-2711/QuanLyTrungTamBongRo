using Microsoft.AspNetCore.Mvc;

namespace NguyenNgoKhanhDuy_DH52200571.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            // Kiểm tra phân quyền đăng nhập
            if (HttpContext.Session.GetString("UserRole") != "Admin")
            {
                return RedirectToAction("Login", "DangNhap");
            }

            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            return View();
        }
    }
}