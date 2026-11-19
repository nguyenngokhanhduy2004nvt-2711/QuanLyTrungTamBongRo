using System;
using System.Collections.Generic;

namespace NguyenNgoKhanhDuy_DH52200571.Models
{
    public partial class DiemDanh
    {
        public int DiemDanhId { get; set; }
        public int HocVienId { get; set; }
        public int LichTapId { get; set; }
        public string? TrangThai { get; set; }
        public string? GhiChu { get; set; }

        public virtual HocVien HocVien { get; set; } = null!;
        public virtual LichTap LichTap { get; set; } = null!;
    }
}
