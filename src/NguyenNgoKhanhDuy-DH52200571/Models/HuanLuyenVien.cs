using System;
using System.Collections.Generic;

namespace NguyenNgoKhanhDuy_DH52200571.Models
{
    public partial class HuanLuyenVien
    {
        public HuanLuyenVien()
        {
            LopHocs = new HashSet<LopHoc>();
            NhanXets = new HashSet<NhanXet>();
        }

        public int Hlvid { get; set; }
        public int UserId { get; set; }
        public string? ChuyenMon { get; set; }
        public string? KinhNghiem { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<LopHoc> LopHocs { get; set; }
        public virtual ICollection<NhanXet> NhanXets { get; set; }
    }
}
