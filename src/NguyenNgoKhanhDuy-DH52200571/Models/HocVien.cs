using System;
using System.Collections.Generic;

namespace NguyenNgoKhanhDuy_DH52200571.Models
{
    public partial class HocVien
    {
        public HocVien()
        {
            DangKies = new HashSet<DangKy>();
            DiemDanhs = new HashSet<DiemDanh>();
            NhanXets = new HashSet<NhanXet>();
        }

        public int HocVienId { get; set; }
        public int ParentId { get; set; }
        public string HoTen { get; set; } = null!;
        public DateTime? NgaySinh { get; set; }
        public string? GioiTinh { get; set; }
        public string? DiaChi { get; set; }

        public virtual User Parent { get; set; } = null!;
        public virtual ICollection<DangKy> DangKies { get; set; }
        public virtual ICollection<DiemDanh> DiemDanhs { get; set; }
        public virtual ICollection<NhanXet> NhanXets { get; set; }
    }
}
