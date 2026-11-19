using System;
using System.Collections.Generic;

namespace NguyenNgoKhanhDuy_DH52200571.Models
{
    public partial class LichTap
    {
        public LichTap()
        {
            DiemDanhs = new HashSet<DiemDanh>();
        }

        public int LichTapId { get; set; }
        public int LopHocId { get; set; }
        public int SanTapId { get; set; }
        public DateTime NgayTap { get; set; }
        public TimeSpan GioBatDau { get; set; }
        public TimeSpan GioKetThuc { get; set; }

        public virtual LopHoc LopHoc { get; set; } = null!;
        public virtual SanTap SanTap { get; set; } = null!;
        public virtual ICollection<DiemDanh> DiemDanhs { get; set; }
    }
}
