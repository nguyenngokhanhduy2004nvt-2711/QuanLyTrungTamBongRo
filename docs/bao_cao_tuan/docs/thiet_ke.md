# THIẾT KẾ HỆ THỐNG - WEBSITE QUẢN LÝ TRUNG TÂM BÓNG RỔ

## 1. Mô hình thực thể kết hợp (ERD) - Chi tiết các bảng dữ liệu

### **Bảng 1: Users** (Quản lý người dùng & phân quyền)
- **`Id`** (INT, Primary Key, Auto Increment): Mã người dùng
- **`HoTen`** (NVARCHAR(100), Not Null): Họ và tên người dùng
- **`Email`** (VARCHAR(100), Not Null, Unique): Email đăng nhập hệ thống
- **`MatKhauHash`** (VARCHAR(255), Not Null): Mật khẩu đã mã hóa
- **`VaiTro`** (VARCHAR(20), Not Null): Phân quyền (`Admin`, `HLV`, `PhuHuynh`)

### **Bảng 2: LopHoc** (Quản lý các lớp bóng rổ)
- **`Id`** (INT, Primary Key, Auto Increment): Mã lớp học
- **`TenLop`** (NVARCHAR(100), Not Null): Tên lớp (Ví dụ: Lớp U10 Cơ bản, Lớp U14 Nâng cao)
- **`HLV_Id`** (INT, Foreign Key -> `Users.Id`): Huấn luyện viên phụ trách lớp này
- **`LichHoc`** (NVARCHAR(200), Not Null): Khung giờ và ngày tập trong tuần
- **`SiSoToiDa`** (INT, Not Null): Số lượng học viên tối đa cho phép trong lớp

### **Bảng 3: HocVien** (Quản lý thông tin học viên)
- **`Id`** (INT, Primary Key, Auto Increment): Mã học viên
- **`HoTen`** (NVARCHAR(100), Not Null): Họ và tên học viên
- **`NgaySinh`** (DATE, Not Null): Ngày tháng năm sinh của học viên
- **`PhuHuynh_Id`** (INT, Foreign Key -> `Users.Id`): Tài khoản phụ huynh giám sát/đăng ký
- **`Lop_Id`** (INT, Foreign Key -> `LopHoc.Id`, Nullable): Lớp học viên đang theo học

### **Bảng 4: DiemDanh** (Ghi nhận điểm danh buổi tập)
- **`Id`** (INT, Primary Key, Auto Increment): Mã bản ghi điểm danh
- **`Lop_Id`** (INT, Foreign Key -> `LopHoc.Id`): Lớp học được điểm danh
- **`HocVien_Id`** (INT, Foreign Key -> `HocVien.Id`): Học viên được điểm danh
- **`NgayTap`** (DATE, Not Null): Ngày diễn ra buổi tập
- **`CoMat`** (BIT, Not Null): Trạng thái (`1`: Có mặt, `0`: Vắng mặt)

### **Bảng 5: HocPhi** (Quản lý học phí và số buổi)
- **`Id`** (INT, Primary Key, Auto Increment): Mã hóa đơn học phí
- **`HocVien_Id`** (INT, Foreign Key -> `HocVien.Id`): Học viên đóng học phí
- **`SoTien`** (DECIMAL(18,2), Not Null): Số tiền học phí của gói
- **`SoBuoiDangKy`** (INT, Not Null): Tổng số buổi học tương ứng với gói đóng
- **`DaThanhToan`** (BIT, Not Null): Trạng thái (`1`: Đã hoàn thành đóng phí, `0`: Chưa đóng)

## 2. Mối quan hệ giữa các bảng (Relationships)
- **`Users`** (1) -> (N) **`LopHoc`**: Một HLV có thể phụ trách nhiều lớp học.
- **`Users`** (1) -> (N) **`HocVien`**: Một tài khoản phụ huynh có thể quản lý nhiều học viên.
- **`LopHoc`** (1) -> (N) **`HocVien`**: Một lớp học chứa nhiều học viên.
- **`LopHoc`** (1) -> (N) **`DiemDanh`**: Một lớp học có nhiều lượt điểm danh theo các buổi tập.
- **`HocVien`** (1) -> (N) **`DiemDanh`**: Một học viên có lịch sử điểm danh qua nhiều buổi.
- **`HocVien`** (1) -> (N) **`HocPhi`**: Một học viên có thể có nhiều hóa đơn đóng học phí.
