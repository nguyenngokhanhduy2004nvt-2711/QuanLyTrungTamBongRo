using System;
using System.Collections.Generic;

namespace NguyenNgoKhanhDuy_DH52200571.Models
{
    public partial class SanTap
    {
        public SanTap()
        {
            LichTaps = new HashSet<LichTap>();
        }

        public int SanTapId { get; set; }
        public string TenSan { get; set; } = null!;
        public string? DiaChi { get; set; }
        public int? SucChua { get; set; }
        public string? TrangThai { get; set; }

        public virtual ICollection<LichTap> LichTaps { get; set; }
    }
}
