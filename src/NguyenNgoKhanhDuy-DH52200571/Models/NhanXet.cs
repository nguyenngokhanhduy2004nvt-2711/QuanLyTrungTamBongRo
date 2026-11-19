using System;
using System.Collections.Generic;

namespace NguyenNgoKhanhDuy_DH52200571.Models
{
    public partial class NhanXet
    {
        public int NhanXetId { get; set; }
        public int HocVienId { get; set; }
        public int Hlvid { get; set; }
        public string? NoiDung { get; set; }
        public DateTime? NgayNhanXet { get; set; }

        public virtual HuanLuyenVien Hlv { get; set; } = null!;
        public virtual HocVien HocVien { get; set; } = null!;
    }
}
