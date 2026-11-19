
using System.ComponentModel.DataAnnotations;

namespace NguyenNgoKhanhDuy_DH52200571
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string HoTen { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string MatKhau { get; set; } = string.Empty;

        [Required]
        public string VaiTro { get; set; } = string.Empty;
        // Admin, HLV, PhuHuynh
    }
}
