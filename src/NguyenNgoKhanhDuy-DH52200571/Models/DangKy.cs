using System;
using System.Collections.Generic;

namespace NguyenNgoKhanhDuy_DH52200571.Models
{
    public partial class DangKy
    {
        public DangKy()
        {
            ThanhToans = new HashSet<ThanhToan>();
        }

        public int DangKyId { get; set; }
        public int HocVienId { get; set; }
        public int LopHocId { get; set; }
        public DateTime? NgayDangKy { get; set; }
        public string? TrangThai { get; set; }

        public virtual HocVien HocVien { get; set; } = null!;
        public virtual LopHoc LopHoc { get; set; } = null!;
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}
