# BÁO CÁO TIẾN ĐỘ THỰC TẬP TỐT NGHIỆP - TUẦN 5

- **Đề tài:** Website quản lý trung tâm bóng rổ (3 phân hệ: Admin, Huấn luyện viên, Phụ huynh)
- **Sinh viên thực hiện:** Nguyễn Ngô Khánh Duy
- **Thời gian báo cáo:** Tuần 5 (Cập nhật đến ngày 12/11/2026)
- **Kho lưu trữ mã nguồn:** https://github.com/nguyenngokhanhduy2004nvt-2711/QuanLyTrungTamBongRo
---

## 1. Công việc đã thực hiện
- **Hoàn thành tài liệu đặc tả:** Viết xong tài liệu đặc tả chi tiết yêu cầu hệ thống (nghiệp vụ quản lý lớp, lịch tập, điểm danh, học phí và phân quyền 3 vai trò) và đã được giảng viên hướng dẫn phê duyệt.
- **Tổ chức kho lưu trữ dự án:** Khởi tạo thành công repository trên GitHub với cấu trúc thư mục theo đúng quy chuẩn hướng dẫn chung (`HD_00`), bao gồm `README.md` và thư mục tài liệu `docs/`.
- **Chuẩn hóa danh mục yêu cầu:** Chuyển đổi đặc tả sang bảng ma trận truy vết (`docs/truy_vet.csv`) phân chia rõ các yêu cầu chức năng (`FR-01` đến `FR-08`) theo hai mức độ: *Bắt buộc* và *Nên có*.
- **Định hướng công nghệ & CSDL:** Thống nhất kiến trúc phát triển bằng **ASP.NET Core MVC, Entity Framework Core, SQL Server** và giao diện **Bootstrap**; phác thảo các bảng dữ liệu cốt lõi (`Users`, `LopHoc`, `HocVien`, `DiemDanh`, `HocPhi`).

---

## 2. Trạng thái các yêu cầu chức năng (Theo `truy_vet.csv`)

| Mã yêu cầu | Mức độ | Nội dung chức năng | Trạng thái | Ghi chú |

| **FR-01** | Bắt buộc | Đăng nhập và phân quyền 3 vai trò (Admin, HLV, Phụ huynh) | Chưa làm | Ưu tiên làm đầu tiên ở tuần6|
| **FR-02** | Bắt buộc | Admin quản lý danh sách HLV và học viên | Chưa làm | |
| **FR-03** | Bắt buộc | Quản lý lớp học có giới hạn sĩ số | Chưa làm | |
| **FR-04** | Bắt buộc | Xếp lịch tập chặn trùng giờ (kể cả đổi lịch và dạy thay) | Chưa làm | |
| **FR-05** | Bắt buộc | HLV thực hiện điểm danh học viên theo buổi | Chưa làm | |
| **FR-06** | Bắt buộc | Quản lý học phí và tính số buổi học còn lại | Chưa làm | |
| **FR-07** | Bắt buộc | Tính bảng lương HLV và ghi nhật ký tài chính | Chưa làm | |
| **FR-08** | Nên có | Quản lý giáo án, thông báo và hộp thư góp ý | Chưa làm | Làm sau khi xong các FR bắt buộc |
---
## 3. Vướng mắc thực tế và Đề xuất
- **Vướng mắc:** Do tham gia nhận đề tài trễ hơn tiến độ chung 4 tuần nên hiện tại phần thiết kế chi tiết cơ sở dữ liệu (ERD) và khung mã nguồn em chưa kịp triển khai.
- **Đề xuất với giảng viên:** 
  1. Em xin phép thầy thống nhất lộ trình triển khai cuốn chiếu từ tuần 5 đến tuần 12 để đảm bảo hoàn thành đầy đủ các yêu cầu mức *Bắt buộc* đúng thời hạn nghiệm thu.
  2. Em xin xác nhận việc sử dụng SQL Server cục bộ (Express/LocalDB) phục vụ quá trình lập trình và kiểm thử cá nhân.

---

## 4. Kế hoạch triển khai tuần tới (Tuần 6)
- Hoàn thiện sơ đồ cơ sở dữ liệu quan hệ (ERD) và lưu vào tài liệu thiết kế (`docs/thiet_ke.md`).
- Khởi tạo dự án **ASP.NET Core MVC**, cấu hình kết nối cơ sở dữ liệu thông qua Entity Framework Core và tạo dữ liệu mẫu giả lập (tài khoản Admin, HLV, Phụ huynh).
- Hiện thực và kiểm thử hoàn chỉnh chức năng **FR-01** (Đăng nhập và điều hướng phân quyền theo vai trò).
