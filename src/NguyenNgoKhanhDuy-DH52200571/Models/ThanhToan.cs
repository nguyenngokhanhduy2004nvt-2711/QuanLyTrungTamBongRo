using System;
using System.Collections.Generic;

namespace NguyenNgoKhanhDuy_DH52200571.Models
{
    public partial class ThanhToan
    {
        public int ThanhToanId { get; set; }
        public int DangKyId { get; set; }
        public decimal SoTien { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public string? PhuongThuc { get; set; }
        public string? TrangThai { get; set; }

        public virtual DangKy DangKy { get; set; } = null!;
    }
}
