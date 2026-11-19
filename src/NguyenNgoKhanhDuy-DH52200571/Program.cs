using Microsoft.EntityFrameworkCore;
using NguyenNgoKhanhDuy_DH52200571;
using NguyenNgoKhanhDuy_DH52200571.Models;
var builder = WebApplication.CreateBuilder(args);

// 1. Kết nối SQL Server
builder.Services.AddDbContext<BongRoContext>(options => options.UseSqlServer( builder.Configuration.GetConnectionString("DefaultConnection")));
// 2. Đăng ký bộ nhớ và bật Session để quản lý đăng nhập
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
builder.Services.AddControllersWithViews();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// 3. Kích hoạt Session
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=DangNhap}/{action=Login}/{id?}");

app.Run();