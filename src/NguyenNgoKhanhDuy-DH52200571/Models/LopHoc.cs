using System;
using System.Collections.Generic;

namespace NguyenNgoKhanhDuy_DH52200571.Models
{
    public partial class LopHoc
    {
        public LopHoc()
        {
            DangKies = new HashSet<DangKy>();
            LichTaps = new HashSet<LichTap>();
        }

        public int LopHocId { get; set; }
        public string TenLop { get; set; } = null!;
        public int Hlvid { get; set; }
        public string? MoTa { get; set; }
        public decimal? HocPhi { get; set; }
        public string? TrangThai { get; set; }

        public virtual HuanLuyenVien Hlv { get; set; } = null!;
        public virtual ICollection<DangKy> DangKies { get; set; }
        public virtual ICollection<LichTap> LichTaps { get; set; }
    }
}
