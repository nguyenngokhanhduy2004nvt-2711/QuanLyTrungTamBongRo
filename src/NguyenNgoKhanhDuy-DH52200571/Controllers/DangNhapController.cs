using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NguyenNgoKhanhDuy_DH52200571.Models;

namespace NguyenNgoKhanhDuy_DH52200571.Controllers
{
    public class DangNhapController : Controller
    {
        private readonly BongRoContext _context;

        public DangNhapController(BongRoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string matKhau)
        {
            // Kiểm tra thông tin đăng nhập
            var user = _context.Users.FirstOrDefault(
                u => u.Email == email && u.MatKhau == matKhau);

            if (user != null)
            {
                // Lưu thông tin đăng nhập
                HttpContext.Session.SetInt32("UserId", user.Id);
                HttpContext.Session.SetString("UserName", user.HoTen);
                HttpContext.Session.SetString("UserRole", user.VaiTro);

                if (user.VaiTro == "Admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                else if (user.VaiTro == "HLV")
                {
                    return RedirectToAction("Index", "Coach");
                }
                else if (user.VaiTro == "PhuHuynh")
                {
                    return RedirectToAction("Index", "PhuHuynh");
                }
            }

            ViewBag.Error = "Email hoặc mật khẩu không chính xác!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
