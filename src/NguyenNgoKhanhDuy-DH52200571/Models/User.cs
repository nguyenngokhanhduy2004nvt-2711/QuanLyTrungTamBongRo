using System;
using System.Collections.Generic;

namespace NguyenNgoKhanhDuy_DH52200571.Models
{
    public partial class User
    {
        public User()
        {
            HocViens = new HashSet<HocVien>();
            HuanLuyenViens = new HashSet<HuanLuyenVien>();
        }

        public int Id { get; set; }
        public string HoTen { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string VaiTro { get; set; } = null!;

        public virtual ICollection<HocVien> HocViens { get; set; }
        public virtual ICollection<HuanLuyenVien> HuanLuyenViens { get; set; }
    }
}
