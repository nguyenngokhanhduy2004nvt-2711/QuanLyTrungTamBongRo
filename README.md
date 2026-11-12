# WEBSITE QUẢN LÝ TRUNG TÂM BÓNG RỔ
Đồ án thực tập tốt nghiệp xây dựng hệ thống quản lý hoạt động của trung tâm bóng rổ với 3 phân hệ người dùng: **Quản trị viên (Admin)**, **Huấn luyện viên (HLV)** và **Phụ huynh**.
## 1. Thông tin chung
- **Sinh viên thực hiện:** Nguyễn Ngô Khánh Duy
- **Công nghệ sử dụng:** ASP.NET Core MVC, Entity Framework Core, SQL Server, Bootstrap 5.
## 2. Cấu trúc thư mục dự án
- `docs/`: Chứa tài liệu đặc tả yêu cầu, thiết kế hệ thống (ERD), bảng ma trận truy vết (`truy_vet.csv`) và báo cáo tiến độ hàng tuần.
- `src/`: Chứa mã nguồn chính của ứng dụng ASP.NET Core MVC.
- `tests/`: Chứa các kịch bản và kết quả kiểm thử chức năng.
- `deploy/`: Chứa script khởi tạo cơ sở dữ liệu (`database.sql`) và hướng dẫn cài đặt.
- `data/sample/`: Chứa dữ liệu mẫu giả lập phục vụ kiểm thử (`du_lieu_mau.sql`).
- `evidence/`: Chứa hình ảnh, video minh chứng nghiệm thu từng chức năng.
## 3. Các chức năng chính
1. Đăng nhập và phân quyền theo 3 vai trò (`Admin`, `HLV`, `PhuHuynh`).
2. Quản lý danh sách huấn luyện viên, học viên và lớp học (có giới hạn sĩ số).
3. Xếp lịch tập và kiểm tra trùng lịch.
4. Điểm danh học viên theo từng buổi tập.
5. Quản lý học phí, theo dõi số buổi học còn lại và tính lương huấn luyện viên.
