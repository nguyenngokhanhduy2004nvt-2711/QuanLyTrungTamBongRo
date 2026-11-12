-- DỮ LIỆU MẪU GIẢ LẬP 
USE BongRoDB;
GO

-- 1. Thêm 3 tài khoản mẫu đại diện cho 3 vai trò (Mật khẩu mẫu: 123456)
INSERT INTO Users (HoTen, Email, MatKhauHash, VaiTro) VALUES 
(N'Quản Trị Viên', 'admin@bongro.vn', '123456', 'Admin'),
(N'HLV Nguyễn Văn An', 'hlv.an@bongro.vn', '123456', 'HLV'),
(N'Phụ Huynh Trần Thị Bình', 'ph.binh@gmail.com', '123456', 'PhuHuynh');

-- 2. Thêm 2 lớp học bóng rổ mẫu (Do HLV có Id = 2 phụ trách)
INSERT INTO LopHoc (TenLop, HLV_Id, LichHoc, SiSoToiDa) VALUES 
(N'Lớp U10 Cơ Bản', 2, N'Thứ 3 - Thứ 5 (17h30 - 19h00)', 15),
(N'Lớp U14 Nâng Cao', 2, N'Thứ 7 - Chủ Nhật (08h00 - 10h00)', 12);

-- 3. Thêm 2 học viên mẫu (Con của Phụ huynh có Id = 3)
INSERT INTO HocVien (HoTen, NgaySinh, PhuHuynh_Id, Lop_Id) VALUES 
(N'Trần Minh Khôi', '2016-05-12', 3, 1),
(N'Trần Gia Huy', '2012-09-20', 3, 2);

-- 4. Thêm dữ liệu học phí mẫu
INSERT INTO HocPhi (HocVien_Id, SoTien, SoBuoiDangKy, DaThanhToan) VALUES 
(1, 1500000, 12, 1),
(2, 1800000, 12, 0);
