using Microsoft.AspNetCore.Mvc;

namespace NguyenNgoKhanhDuy_DH52200571.Controllers
{
    public class PhuHuynhController : Controller
    {
        public IActionResult Index()
        {
            // Kiểm tra quyền truy cập phải là PhuHuynh
            if (HttpContext.Session.GetString("UserRole") != "PhuHuynh")
            {
                return RedirectToAction("Login", "DangNhap");
            }

            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            return View();
        }
    }
}
